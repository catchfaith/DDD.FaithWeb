using FaithBlog.Domain.Entities;
using FaithBlog.Domain.Interfaces;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaithBlog.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<SysUser,long>,IUserRepository
    {

        public UserRepository(ISqlSugarClient db) : base(db)
        {
        }

        public async Task<bool> AddAsync(SysUser user)
        {
            return await _db.Insertable(user).ExecuteCommandAsync() > 0;
        }

        public async Task<bool> DeleteAsync(SysUser user)
        {
            return await _db.Updateable<SysUser>().ExecuteCommandAsync() > 0;
        }

        public async Task<SysUser> GetUserByIdAsync(long userId)
        {
            return await _db.Queryable<SysUser>().Where(x => x.UserId == userId).FirstAsync();
        }

        public async Task<bool> UpdateAsync(SysUser user)
        {
            return await _db.Updateable<SysUser>(user).ExecuteCommandAsync() > 0;
        }
    }
}
