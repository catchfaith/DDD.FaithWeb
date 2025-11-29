using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace FaithBlog.Domain.Entities
{
    ///<summary>
    ///部门表
    ///</summary>
    [SugarTable("sys_dept")]
    public partial class SysDept
    {
           public SysDept(){


           }
           /// <summary>
           /// Desc:部门id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true,ColumnName="dept_id")]
           public long DeptId {get;set;}

           /// <summary>
           /// Desc:父部门id
           /// Default:0
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="parent_id")]           
           public long? ParentId {get;set;}

           /// <summary>
           /// Desc:祖级列表
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="ancestors")]           
           public string Ancestors {get;set;}

           /// <summary>
           /// Desc:部门名称
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="dept_name")]           
           public string DeptName {get;set;}

           /// <summary>
           /// Desc:显示顺序
           /// Default:0
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="order_num")]           
           public int? OrderNum {get;set;}

           /// <summary>
           /// Desc:负责人
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="leader")]           
           public string Leader {get;set;}

           /// <summary>
           /// Desc:联系电话
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="phone")]           
           public string Phone {get;set;}

           /// <summary>
           /// Desc:邮箱
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="email")]           
           public string Email {get;set;}

           /// <summary>
           /// Desc:部门状态（0正常 1停用）
           /// Default:0
           /// Nullable:True
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

    }
}
