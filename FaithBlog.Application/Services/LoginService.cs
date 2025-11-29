using FaithBlog.Application.Dtos;
using FaithBlog.Application.Events;
using FaithBlog.Application.Interfaces;
using FaithBlog.Application.Models;
using FaithBlog.Application.VO.Login;
using FaithBlog.Domain.Interfaces;
using FaithBlog.Shared.Interfaces;
using MediatR;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaithBlog.Application.Services
{
    public class LoginService : ILoginService
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;
        private readonly IMediator _mediator;
        private readonly ICaptchaService _cacheService;

        public LoginService(
            IUserRepository userRepository, 
            IMediator mediator,
            ITokenService tokenService,
            ICaptchaService cacheService)
        {
            _userRepository = userRepository;
            _mediator = mediator;
            _tokenService = tokenService;
            _cacheService = cacheService;
        }

        /// <summary>
        /// 登录接口
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Result<LoginResultDto>> LoginAsync(LoginRequest request)
        {
            try
            {
                throw new Exception();
                //if (string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Password))
                //    return Result<LoginResultDto>.Fail("用户名或密码不能为空");
                //var user = await _userRepository.GetByUserByNameAsync(request.Username);
                //if (user == null || user.PasswordHash != request.Password)
                //    return Result<LoginResultDto>.Fail("用户名或密码错误");
                ////先判断验证码是否有效
                //var captFlag = _cacheService.ValidateCaptcha(request.Username, request.Password);

                ////验证账号密码 生成token
                //var token = _tokenService.GenerateToken(user.Id, user.Username);

                ////发布订阅
                //await _mediator.Publish(new UserLoggedInEvent
                //{
                //    UserId = user.Id,
                //    Username = user.Username,
                //    LoginTime = DateTime.Now,
                //    IP = "" // 可由控制器传入
                //});

                //return Result<LoginResultDto>.Ok(new LoginResultDto
                //{
                //    UserId = user.Id,
                //    Username = user.Username,
                //    token = token
                //});
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    
    
    
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<Result<LoginResultDto>> RegisterAsync(RegisterRequest request)
        {
            try
            {
                //if (string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Password))
                //    return Result<LoginResultDto>.Fail("用户名或密码不能为空");
                //var existingUser = await _userRepository.GetByUserByNameAsync(request.Username);
                //if (existingUser != null)
                //    return Result<LoginResultDto>.Fail("用户名已存在");
                //var user = new User
                //{
                //    Id = Guid.NewGuid().ToString(),
                //    Username = request.Username,
                //    PasswordHash = request.Password, // 这里应该使用哈希加密
                //    IsActive = true,
                //    Email = request.Email,//应该做校验
                //    Phone = request.Phone,
                //    CreatedAt = DateTime.Now,
                //    UpdatedAt = DateTime.Now
                //};
                //await _userRepository.AddAsync(user);
                //// 生成token
                //var token = _tokenService.GenerateToken(user.Id, user.Username);
                //return Result<LoginResultDto>.Ok(new LoginResultDto
                //{
                //    UserId = user.Id,
                //    Username = user.Username,
                //    token = token
                //});
                throw new Exception();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// 获取图片验证码
        /// </summary>
        /// <returns></returns>
        public CaptchaDto GetGenerateCaptchaAsync() {
            try
            {
               var res = _cacheService.GenerateCaptcha();
                return new CaptchaDto() { 
                Base64Image = res.Base64Image,
                CaptchaId = res.CaptchaId
                };
            }
            catch (Exception)
            {

                throw;
            }
        }
    } 
}
