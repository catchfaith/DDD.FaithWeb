using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaithBlog.Application.Events
{
    public class UserLoggedInEvent : INotification
    {
        /// <summary>
        /// 用户唯一标识
        /// </summary>
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 用户名
        /// </summary>
        public string Username { get; set; } = default!;

        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime LoginTime { get; set; }

        /// <summary>
        /// 登录 IP 地址
        /// </summary>
        public string? IP { get; set; }
    }
}
