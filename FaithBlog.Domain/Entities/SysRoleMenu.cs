using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace FaithBlog.Domain.Entities
{
    ///<summary>
    ///角色和菜单关联表
    ///</summary>
    [SugarTable("sys_role_menu")]
    public partial class SysRoleMenu
    {
           public SysRoleMenu(){


           }
           /// <summary>
           /// Desc:角色ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,ColumnName="role_id")]
           public long RoleId {get;set;}

           /// <summary>
           /// Desc:菜单ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,ColumnName="menu_id")]
           public long MenuId {get;set;}

    }
}
