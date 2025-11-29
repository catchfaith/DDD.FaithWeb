using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaithBlog.Application.Dtos
{
    public class CaptchaDto
    {
        public string Base64Image { get; set; }
        public string CaptchaId { get; set; }
    }
}
