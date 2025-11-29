using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace FaithBlog.Domain.Entities
{
    ///<summary>
    ///岗位信息表
    ///</summary>
    [SugarTable("sys_post")]
    public partial class SysPost
    {
           public SysPost(){


           }
           /// <summary>
           /// Desc:岗位ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true,ColumnName="post_id")]
           public long PostId {get;set;}

           /// <summary>
           /// Desc:岗位编码
           /// Default:
           /// Nullable:False
           /// </summary>
           [SugarColumn(ColumnName="post_code")]           
           public string PostCode {get;set;}

           /// <summary>
           /// Desc:岗位名称
           /// Default:
           /// Nullable:False
           /// </summary>
           [SugarColumn(ColumnName="post_name")]           
           public string PostName {get;set;}

           /// <summary>
           /// Desc:显示顺序
           /// Default:
           /// Nullable:False
           /// </summary>
           [SugarColumn(ColumnName="post_sort")]           
           public int PostSort {get;set;}

           /// <summary>
           /// Desc:状态（0正常 1停用）
           /// Default:
           /// Nullable:False
           /// </summary>
           [SugarColumn(ColumnName="status")]           
           public string Status {get;set;}

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
