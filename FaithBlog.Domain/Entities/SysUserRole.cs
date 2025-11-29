using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace FaithBlog.Domain.Entities
{
    ///<summary>
    ///用户和角色关联表
    ///</summary>
    [SugarTable("sys_user_role")]
    public partial class SysUserRole
    {
           public SysUserRole(){


           }
           /// <summary>
           /// Desc:用户ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,ColumnName="user_id")]
           public long UserId {get;set;}

           /// <summary>
           /// Desc:角色ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,ColumnName="role_id")]
           public long RoleId {get;set;}

    }
}
