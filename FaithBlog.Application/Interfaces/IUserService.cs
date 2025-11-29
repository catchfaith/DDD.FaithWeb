using FaithBlog.Application.Dtos.UserDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaithBlog.Application.Interfaces
{
    public interface IUserService
    {
        Task<bool> AddUserAsync(UserCreateDto createDto);
        Task<object> DeleteUserAsync(long id);
        Task<object> UpdateUserAsync(UserUpdateDto updateDto,long userId);
    }
}
