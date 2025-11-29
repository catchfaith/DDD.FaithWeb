using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace FaithBlog.Domain.Entities
{
    ///<summary>
    ///角色信息表
    ///</summary>
    [SugarTable("sys_role")]
    public partial class SysRole
    {
           public SysRole(){


           }
           /// <summary>
           /// Desc:角色ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true,ColumnName="role_id")]
           public long RoleId {get;set;}

           /// <summary>
           /// Desc:角色名称
           /// Default:
           /// Nullable:False
           /// </summary>
           [SugarColumn(ColumnName="role_name")]           
           public string RoleName {get;set;}

           /// <summary>
           /// Desc:角色权限字符串
           /// Default:
           /// Nullable:False
           /// </summary>
           [SugarColumn(ColumnName="role_key")]           
           public string RoleKey {get;set;}

           /// <summary>
           /// Desc:显示顺序
           /// Default:
           /// Nullable:False
           /// </summary>
           [SugarColumn(ColumnName="role_sort")]           
           public int RoleSort {get;set;}

           /// <summary>
           /// Desc:数据范围（1：全部数据权限 2：自定数据权限 3：本部门数据权限 4：本部门及以下数据权限）
           /// Default:1
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="data_scope")]           
           public string DataScope {get;set;}

           /// <summary>
           /// Desc:角色状态（0正常 1停用）
           /// Default:
           /// Nullable:False
           /// </summary>
           [SugarColumn(ColumnName="status")]           
           public string Status {get;set;}

           /// <summary>
           /// Desc:删除标志（0代表存在 2代表删除）
           /// Default:0
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="del_flag")]           
           public string DelFlag {get;set;}

           /// <summary>
           /// Desc:创建者
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="create_by")]           
           public string CreateBy {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="create_time")]           
           public DateTime? CreateTime {get;set;}

           /// <summary>
           /// Desc:更新者
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="update_by")]           
           public string UpdateBy {get;set;}

           /// <summary>
           /// Desc:更新时间
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="update_time")]           
           public DateTime? UpdateTime {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="remark")]           
           public string Remark {get;set;}

    }
}
