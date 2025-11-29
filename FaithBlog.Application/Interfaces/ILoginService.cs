using FaithBlog.Application.Dtos;
using FaithBlog.Application.Models;
using FaithBlog.Application.VO.Login;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaithBlog.Application.Interfaces
{
    public interface ILoginService
    {
        Task<Result<LoginResultDto>> LoginAsync(LoginRequest request);
        Task<Result<LoginResultDto>> RegisterAsync(RegisterRequest request);
        CaptchaDto GetGenerateCaptchaAsync();
    }
}
