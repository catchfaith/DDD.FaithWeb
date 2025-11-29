
using FaithBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaithBlog.Domain.Interfaces
{
    public interface IUserRepository : IBaseRepository<SysUser,long>
    {
        Task<bool> AddAsync(SysUser user);
        Task<SysUser> GetUserByIdAsync(long userId);
        Task<bool> DeleteAsync(SysUser user);
    }
}
