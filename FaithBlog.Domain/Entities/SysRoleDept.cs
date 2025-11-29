using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace FaithBlog.Domain.Entities
{
    ///<summary>
    ///角色和部门关联表
    ///</summary>
    [SugarTable("sys_role_dept")]
    public partial class SysRoleDept
    {
           public SysRoleDept(){


           }
           /// <summary>
           /// Desc:角色ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,ColumnName="role_id")]
           public long RoleId {get;set;}

           /// <summary>
           /// Desc:部门ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,ColumnName="dept_id")]
           public long DeptId {get;set;}

    }
}
