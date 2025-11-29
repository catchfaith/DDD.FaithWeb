using FaithBlog.Application.Dtos;
using FaithBlog.Application.Dtos.UserDTO;
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
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost("user")]
        public async Task<object> AddUserAsync([FromBody] UserCreateDto request)
        {
            return await userService.AddUserAsync(request);
        }

        [HttpPut("user/{id}")]
        public async Task<object> UpdateUserAsync([FromBody] UserCreateDto request, [FromRoute] long id)
        {
            return await userService.AddUserAsync(request);
        }

        [HttpDelete("user/{id}")]
        public async Task<object> DeleteUserAsync([FromRoute] long id)
        {
            return await userService.DeleteUserAsync(id);
        }
    }
}
