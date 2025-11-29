using AutoMapper;
using FaithBlog.Application.Dtos.UserDTO;
using FaithBlog.Application.Interfaces;
using FaithBlog.Domain.Factory;
using FaithBlog.Domain.Interfaces;
using FaithBlog.Domain.Param;
using FaithBlog.Shared.mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaithBlog.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository repository; 
        public UserService(IUserRepository repository) { 
            this.repository = repository;
        }
        public async Task<bool> AddUserAsync(UserCreateDto createDto)
        {
            //DTO转参数对象
            UserCreateParam param = MapperHelper.Map<UserCreateDto, UserCreateParam>(createDto);
            //工厂创建实体
            var user = UserFactory.Create(param);
            //存储到数据库
            return await repository.AddAsync(user);
        }

        public Task<object> DeleteUserAsync(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<object> UpdateUserAsync(UserUpdateDto updateDto,long userId)
        {
            UserUpdateParam param = MapperHelper.Map<UserUpdateDto, UserUpdateParam>(updateDto);
            var user = await repository.GetUserByIdAsync(userId);
            UserFactory.VerificationUpdateDto(param);
            user.Update(param);
            return await repository.AddAsync(user);

        }
    }
}
