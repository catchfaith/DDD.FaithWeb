using FaithBlog.Shared.Interfaces;
using Microsoft.Extensions.Caching.Memory;
using SixLabors.Fonts;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Drawing.Processing;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System;
using System.IO;

namespace FaithBlog.Infrastructure.Service
{
    public class CaptchaService : ICaptchaService
    {
        private readonly IMemoryCache _cache;
        private readonly TimeSpan _expire = TimeSpan.FromMinutes(5);

        public CaptchaService(IMemoryCache cache)
        {
            _cache = cache;
        }

        /// <summary>
        /// 生成随机验证码字符串
        /// </summary>
        private static string RndNum(int length)
        {
            string chars = "0123456789abcdefghijkmnpqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ";
            Random rand = new Random();
            char[] code = new char[length];
            for (int i = 0; i < length; i++)
            {
                code[i] = chars[rand.Next(chars.Length)];
            }
            return new string(code);
        }

        /// <summary>
        /// 生成验证码图片
        /// </summary>
        public static MemoryStream Create(out string code, int numbers = 4)
        {
            code = RndNum(numbers);
            var text = code;
            int width = numbers * 30;
            int height = 50;
            var ms = new MemoryStream();

            using (var image = new Image<Rgba32>(width, height, Color.White))
            {
                var random = new Random();

                // 背景噪点
                for (int i = 0; i < 50; i++)
                {
                    int x = random.Next(width);
                    int y = random.Next(height);
                    image[x, y] = Color.LightGray;
                }

                // 字体
                var font = SystemFonts.CreateFont("Arial", 24, FontStyle.Bold);

                // 绘制验证码字符
                for (int i = 0; i < text.Length; i++)
                {
                    var position = new SixLabors.ImageSharp.PointF(5 + i * 25, random.Next(0, 10));
                    image.Mutate(ctx =>
                        ctx.DrawText(
                            text[i].ToString(),
                            font,
                            GetRandomColor(random),
                            position
                        )
                    );
                }

                // 输出为 JPEG
                image.Save(ms, new JpegEncoder());
            }

            ms.Position = 0;
            return ms;
        }

        /// <summary>
        /// 生成随机颜色
        /// </summary>
        private static Color GetRandomColor(Random random)
        {
            return Color.FromRgb(
                (byte)random.Next(0, 256),
                (byte)random.Next(0, 256),
                (byte)random.Next(0, 256)
            );
        }

        /// <summary>
        /// 生成验证码（返回 Base64 图片和验证码 ID）
        /// </summary>
        public (string Base64Image, string CaptchaId) GenerateCaptcha()
        {
            string code;
            using var ms = Create(out code);

            var captchaId = Guid.NewGuid().ToString("N");
            _cache.Set(captchaId, code.ToLower(), _expire);

            var base64 = Convert.ToBase64String(ms.ToArray());
            return ($"data:image/jpeg;base64,{base64}", captchaId);
        }

        /// <summary>
        /// 验证验证码
        /// </summary>
        public bool ValidateCaptcha(string captchaId, string code)
        {
            if (_cache.TryGetValue(captchaId, out string storedCode))
            {
                _cache.Remove(captchaId);
                return storedCode.Equals(code.ToLower(), StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }
    }
}
