using FaithBlog.Application.Dtos;
using FaithBlog.Application.Interfaces;
using FaithBlog.Application.Models;
using FaithBlog.Application.VO.Login;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FaithBlog.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILoginService _userAppService;

        public AuthController(ILoginService userAppService)
        {
            _userAppService = userAppService;
        }

        [HttpPost("login")]
        public async Task<Result<LoginResultDto>> Login([FromBody] LoginRequest request)
        {
            return await _userAppService.LoginAsync(request);
        }

        [HttpPost("register")]
        public async Task<Result<LoginResultDto>> Register([FromBody] RegisterRequest request)
        {
            return await _userAppService.RegisterAsync(request);
        }

        [HttpGet("captcha")]
        public CaptchaDto GetGenerateCaptchaAsync()
        {
            return _userAppService.GetGenerateCaptchaAsync();
        }

    }
}
