using FaithBlog.Domain.Interfaces;
using FaithBlog.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaithBlog.Infrastructure.Database
{
    public static class SqlSugarSetup
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
        {

            #region DBFirst
            //// 注意这里用绝对路径，确保能生成到 Domain/Entities
            //string entityPath = Path.Combine(
            //    Directory.GetParent(Directory.GetCurrentDirectory()).FullName,
            //    "FaithBlog.Domain",
            //    "Entities"
            //);
            //var db = new SqlSugarClient(new ConnectionConfig
            //{
            //    ConnectionString = config.GetConnectionString("Default"),
            //    DbType = DbType.MySql,
            //    IsAutoCloseConnection = true,
            //    InitKeyType = InitKeyType.Attribute
            //});
            //// 生成所有表 -> 输出到 Domain/Entities 文件夹，命名空间指定为 Domain.Entities
            //   db.DbFirst
            //    .IsCreateAttribute()//创建sqlsugar自带特性
            //    .FormatFileName(it => ToPascalCase(it))
            //    .FormatClassName(it => ToPascalCase(it))
            //    .FormatPropertyName(it => ToPropPascalCase(it))
            //    .CreateClassFile(entityPath, "FaithBlog.Domain.Entities");

            #endregion

            services.AddScoped<ISqlSugarClient>(_ =>
            {
                var client = new SqlSugarClient(new ConnectionConfig
                {
                    ConnectionString = config.GetConnectionString("Default"),
                    DbType = DbType.MySql,
                    IsAutoCloseConnection = true,
                    InitKeyType = InitKeyType.Attribute
                });

                // 这里可以启用SQL调试日志
                client.Aop.OnLogExecuting = (sql, pars) =>
                {
                    Console.WriteLine(sql);
                };

                return client;
            });
            services.AddScoped(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }

        // 工具方法：下划线转 PascalCase
        static string ToPascalCase(string name)
        {
            if (string.IsNullOrEmpty(name)) return name;
            return string.Join("",
                name.Split('_', StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => char.ToUpperInvariant(s[0]) + s.Substring(1).ToLowerInvariant()));
        }
        static string ToPropPascalCase(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return input;

            return string.Join("",
                input.Split(new[] { '_', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(word => char.ToUpperInvariant(word[0]) + word.Substring(1).ToLowerInvariant()));
        }
    }
}
