using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaithBlog.Application.Models
{
    public class Result<T>
    {
        public int code { get; set; }
        public string? Message { get; set; }
        public T? Data { get; set; }

        public static Result<T> Ok(T data) => new() { code = 0, Data = data };
        public static Result<T> Fail(string msg) => new() { code = -1, Message = msg };
    }
}
