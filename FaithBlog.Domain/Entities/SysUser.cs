using FaithBlog.Domain.Param;
using SqlSugar;
using System;
using System.Linq;
using System.Text;

namespace FaithBlog.Domain.Entities
{
    ///<summary>
    ///用户信息表
    ///</summary>
    [SugarTable("sys_user")]
    public partial class SysUser
    {
        public SysUser()
        {


        }

        /// <summary>
        /// 实例化构造函数
        /// </summary>
        /// <param name="userCreateParam"></param>
        public SysUser(UserCreateParam userCreateParam)
        {
            //雪花id
            this.UserId = SqlSugar.SnowFlakeSingle.instance.NextId();
            this.DeptId = userCreateParam.DeptId;
            this.LoginName = userCreateParam.LoginName;
            this.UserName = userCreateParam.UserName;
            this.UserType = userCreateParam.UserType;
            this.Email = userCreateParam.Email;
            this.Phonenumber = userCreateParam.Phonenumber;
            this.Sex = userCreateParam.Sex;
            this.Avatar = userCreateParam.Avatar;
            this.Salt = Guid.NewGuid().ToString("N").Substring(0, 6);
            this.Password = HashPassword(userCreateParam.Password); ;

            this.Status = userCreateParam.Status;
            this.CreateTime = DateTime.Now;
            this.DelFlag = "0";
            this.Remark = userCreateParam.Remark;
        }

        public void Update(UserUpdateParam userUpdateParam) {
            this.DeptId = userUpdateParam.DeptId;
            this.LoginName = userUpdateParam.LoginName;
            this.UserName = userUpdateParam.UserName;
            this.UserType = userUpdateParam.UserType;
            this.Email = userUpdateParam.Email;
            this.Phonenumber = userUpdateParam.Phonenumber;
            this.Sex = userUpdateParam.Sex;
            this.Avatar = userUpdateParam.Avatar;
            this.Status = userUpdateParam.Status;
            this.UpdateTime = DateTime.Now;
            this.Remark = userUpdateParam.Remark;
        }

        public void Delete() {
            this.DelFlag = "2";
        }

        private string HashPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("密码不能为空");

            // 使用Salt + PBKDF2哈希
            using var pbkdf2 = new System.Security.Cryptography.Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes(this.Salt), 10000, System.Security.Cryptography.HashAlgorithmName.SHA256);
            var hash = pbkdf2.GetBytes(32);
            return Convert.ToBase64String(hash);
        }

        // 用于验证密码
        public bool VerifyPassword(string password)
        {
            var hash = HashPassword(password);
            return hash == Password;
        }

        // 可以写一个修改密码方法
        public void ChangePassword(string newPassword)
        {
            Salt = Guid.NewGuid().ToString("N").Substring(0, 6);
            Password = HashPassword(newPassword);
            PwdUpdateDate = DateTime.Now;
        }
        #region 属性
        /// <summary>
        /// Desc:用户ID
        /// Default:
        /// Nullable:False
        /// </summary>           
        [SugarColumn(IsPrimaryKey = true, IsIdentity = false, ColumnName = "user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// Desc:部门ID
        /// Default:
        /// Nullable:True
        /// </summary>
        [SugarColumn(ColumnName = "dept_id")]
        public long? DeptId { get; set; }

        /// <summary>
        /// Desc:登录账号
        /// Default:
        /// Nullable:False
        /// </summary>
        [SugarColumn(ColumnName = "login_name")]
        public string LoginName { get; set; }

        /// <summary>
        /// Desc:用户昵称
        /// Default:
        /// Nullable:True
        /// </summary>
        [SugarColumn(ColumnName = "user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// Desc:用户类型（00系统用户 01注册用户）
        /// Default:00
        /// Nullable:True
        /// </summary>
        [SugarColumn(ColumnName = "user_type")]
        public string UserType { get; set; }

        /// <summary>
        /// Desc:用户邮箱
        /// Default:
        /// Nullable:True
        /// </summary>
        [SugarColumn(ColumnName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Desc:手机号码
        /// Default:
        /// Nullable:True
        /// </summary>
        [SugarColumn(ColumnName = "phonenumber")]
        public string Phonenumber { get; set; }

        /// <summary>
        /// Desc:用户性别（0男 1女 2未知）
        /// Default:0
        /// Nullable:True
        /// </summary>
        [SugarColumn(ColumnName = "sex")]
        public string Sex { get; set; }

        /// <summary>
        /// Desc:头像路径
        /// Default:
        /// Nullable:True
        /// </summary>
        [SugarColumn(ColumnName = "avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// Desc:密码
        /// Default:
        /// Nullable:True
        /// </summary>
        [SugarColumn(ColumnName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Desc:盐加密
        /// Default:
        /// Nullable:True
        /// </summary>
        [SugarColumn(ColumnName = "salt")]
        public string Salt { get; set; }

        /// <summary>
        /// Desc:账号状态（0正常 1停用）
        /// Default:0
        /// Nullable:True
        /// </summary>
        [SugarColumn(ColumnName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Desc:删除标志（0代表存在 2代表删除）
        /// Default:0
        /// Nullable:True
        /// </summary>
        [SugarColumn(ColumnName = "del_flag")]
        public string DelFlag { get; set; }

        /// <summary>
        /// Desc:最后登录IP
        /// Default:
        /// Nullable:True
        /// </summary>
        [SugarColumn(ColumnName = "login_ip")]
        public string LoginIp { get; set; }

        /// <summary>
        /// Desc:最后登录时间
        /// Default:
        /// Nullable:True
        /// </summary>
        [SugarColumn(ColumnName = "login_date")]
        public DateTime? LoginDate { get; set; }

        /// <summary>
        /// Desc:密码最后更新时间
        /// Default:
        /// Nullable:True
        /// </summary>
        [SugarColumn(ColumnName = "pwd_update_date")]
        public DateTime? PwdUpdateDate { get; set; }

        /// <summary>
        /// Desc:创建者
        /// Default:
        /// Nullable:True
        /// </summary>
        [SugarColumn(ColumnName = "create_by")]
        public string CreateBy { get; set; }

        /// <summary>
        /// Desc:创建时间
        /// Default:
        /// Nullable:True
        /// </summary>
        [SugarColumn(ColumnName = "create_time")]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Desc:更新者
        /// Default:
        /// Nullable:True
        /// </summary>
        [SugarColumn(ColumnName = "update_by")]
        public string UpdateBy { get; set; }

        /// <summary>
        /// Desc:更新时间
        /// Default:
        /// Nullable:True
        /// </summary>
        [SugarColumn(ColumnName = "update_time")]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Desc:备注
        /// Default:
        /// Nullable:True
        /// </summary>
        [SugarColumn(ColumnName = "remark")]
        public string Remark { get; set; }
        #endregion


    }
}
