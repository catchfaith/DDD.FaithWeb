using FaithBlog.Application.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaithBlog.Application.Handlers
{
    public class LogLoginHandler : INotificationHandler<UserLoggedInEvent>
    {
        public Task Handle(UserLoggedInEvent notification, CancellationToken cancellationToken)
        {
            // 写入日志系统、数据库、消息队列等
            Console.WriteLine($"用户 {notification.Username} 于 {notification.LoginTime} 登录成功，IP: {notification.IP}");

            return Task.CompletedTask;
        }
    }
}
