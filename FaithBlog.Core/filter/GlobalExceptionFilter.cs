using FaithBlog.Application.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace FaithBlog.Core.filter
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        private readonly ILogger<GlobalExceptionFilter> _logger;

        public GlobalExceptionFilter(ILogger<GlobalExceptionFilter> logger)
        {
            _logger = logger;
        }
        public void OnException(ExceptionContext context)
        {
            // 记录异常日志
            _logger.LogError(context.Exception, "发生未处理的异常");

            // 根据异常类型可以自定义不同的状态码
            var statusCode = (int)HttpStatusCode.InternalServerError;
            var result = new Result<object>()
            {
                code = -1,
                Message = context.Exception.Message
            };
            context.Result = new JsonResult(result)
            {
                StatusCode = statusCode
            };

            // 标记异常已处理
            context.ExceptionHandled = true;
        }
    }
}
