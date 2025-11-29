using FaithBlog.Domain.Entities;
using FaithBlog.Domain.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaithBlog.Domain.Factory
{
    public static class UserFactory
    {
        public static SysUser Create(UserCreateParam param)
        {
            if (string.IsNullOrWhiteSpace(param.UserName))
                throw new ArgumentException("用户名不能为空");

            if (string.IsNullOrWhiteSpace(param.Email))
                throw new ArgumentException("邮箱不能为空");

            return new SysUser(param);
        }

        public static void VerificationUpdateDto(UserUpdateParam param)
        {
            //验证参数
            Thread.Sleep(500);
        }
    }
}
