using AutoMapper;
using FaithBlog.Domain.Entities;
using FaithBlog.Domain.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaithBlog.Application.Dtos.UserDTO;

namespace FaithBlog.Application.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserCreateDto, UserCreateParam>();
            // 其他映射规则
        }
    }
}
