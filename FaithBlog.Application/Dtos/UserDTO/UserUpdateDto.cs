using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaithBlog.Application.Dtos.UserDTO
{
    public class UserUpdateDto
    {
        public long DeptId { get; set; }
        public string LoginName { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Sex { get; set; }
        public string Avatar { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
    }
}
