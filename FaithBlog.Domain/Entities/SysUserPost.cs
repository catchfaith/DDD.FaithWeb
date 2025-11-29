using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace FaithBlog.Domain.Entities
{
    ///<summary>
    ///用户与岗位关联表
    ///</summary>
    [SugarTable("sys_user_post")]
    public partial class SysUserPost
    {
           public SysUserPost(){


           }
           /// <summary>
           /// Desc:用户ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,ColumnName="user_id")]
           public long UserId {get;set;}

           /// <summary>
           /// Desc:岗位ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,ColumnName="post_id")]
           public long PostId {get;set;}

    }
}
