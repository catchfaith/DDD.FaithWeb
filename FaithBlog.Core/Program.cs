using FaithBlog.Application.Events;
using FaithBlog.Application.Interfaces;
using FaithBlog.Application.MappingProfiles;
using FaithBlog.Application.Services;
using FaithBlog.Core.filter;
using FaithBlog.Domain.Interfaces;
using FaithBlog.Infrastructure.Database;
using FaithBlog.Infrastructure.Repositories;
using FaithBlog.Infrastructure.Service;
using FaithBlog.Shared.config;
using FaithBlog.Shared.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;


var builder = WebApplication.CreateBuilder(args);


#region AOP 过滤器 拦截器
builder.Services.AddControllers(options =>
{
    options.Filters.Add<ApiResponseFilter>();
    options.Filters.Add<GlobalExceptionFilter>();
});
#endregion

#region SqlSugar
builder.Services.AddInfrastructure(builder.Configuration);
#endregion

#region 应用层依赖注入
// Add services to the container.
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<ICaptchaService, CaptchaService>();
builder.Services.AddMemoryCache();


//mediatR依赖注入
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(UserLoggedInEvent).Assembly));

//jwt配置
builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));

#endregion

#region 授权
var jwtSettings = builder.Configuration.GetSection("JwtSettings");
var secretKey = jwtSettings.GetValue<string>("SecretKey");
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false, // 根据实际情况启用
        ValidateAudience = false, // 根据实际情况启用
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
        ClockSkew = TimeSpan.Zero
    };
});
#endregion

#region 跨域
// 添加 CORS 服务
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy
            .AllowAnyOrigin()    // 允许任意来源
            .AllowAnyHeader()    // 允许任意请求头
            .AllowAnyMethod();   // 允许任意请求方法
    });
});
#endregion

#region swagger
//mini api 录入到swagger文档
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    // 配置文档标题等
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "FaithBlog API",
        Version = "v1"
    });

    // 添加 JWT 验证支持
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "在下方输入 JWT token（前面不要加 Bearer）",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "bearer", // 小写！
        BearerFormat = "JWT"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});
#endregion


var app = builder.Build();

// 使用 CORS
app.UseCors("AllowAll");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();