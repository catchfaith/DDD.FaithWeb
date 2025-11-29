using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace FaithBlog.Domain.Entities
{
    ///<summary>
    ///字典类型表
    ///</summary>
    [SugarTable("sys_dict_type")]
    public partial class SysDictType
    {
           public SysDictType(){


           }
           /// <summary>
           /// Desc:字典主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true,ColumnName="dict_id")]
           public long DictId {get;set;}

           /// <summary>
           /// Desc:字典名称
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="dict_name")]           
           public string DictName {get;set;}

           /// <summary>
           /// Desc:字典类型
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="dict_type")]           
           public string DictType {get;set;}

           /// <summary>
           /// Desc:状态（0正常 1停用）
           /// Default:0
           /// Nullable:True
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
