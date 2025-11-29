using FaithBlog.Application.VO.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaithBlog.Application.VO.User
{
    /// <summary>
    /// 获取用户列表VO
    /// </summary>
    public class GetUserPageRequest : PageRequest
    {
        public string userName { get; set; }
    }
}
