using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaithBlog.Shared.Interfaces
{
    public interface ICaptchaService
    {
        /// <summary>
        /// 获取验证码
        /// </summary>
        /// <returns></returns>
        (string Base64Image, string CaptchaId) GenerateCaptcha();

        /// <summary>
        /// 验证图片码
        /// </summary>
        /// <param name="captchaId"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        bool ValidateCaptcha(string captchaId, string code);
    }
}
