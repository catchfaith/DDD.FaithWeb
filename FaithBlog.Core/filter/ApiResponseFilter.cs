using FaithBlog.Application.Models;
using FaithBlog.Application.VO.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FaithBlog.Core.filter
{
    public class ApiResponseFilter : IAsyncResultFilter
    {
        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            if (context.Result is ObjectResult objectResult)
            {
                if (objectResult.Value is not Result<object> &&
                    (objectResult.DeclaredType == null || !objectResult.DeclaredType.IsGenericType))
                {
                    var wrapped = Result<object>.Ok(objectResult.Value);
                    context.Result = new ObjectResult(wrapped)
                    {
                        StatusCode = objectResult.StatusCode
                    };
                }
            }
            await next();
        }
    }
}
