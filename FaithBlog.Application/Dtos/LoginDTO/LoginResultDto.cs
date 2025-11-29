using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaithBlog.Application.Dtos
{
    public class LoginResultDto
    {
        public string UserId { get; set; } = default!;
        public string Username { get; set; } = default!;
        public string token { get; set; }
    }
}
