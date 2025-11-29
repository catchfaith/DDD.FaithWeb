using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaithBlog.Application.VO.Login
{
    public class RegisterRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}
