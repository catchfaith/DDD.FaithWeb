using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace FaithBlog.Domain.Entities
{
    ///<summary>
    ///字典数据表
    ///</summary>
    [SugarTable("sys_dict_data")]
    public partial class SysDictData
    {
           public SysDictData(){


           }
           /// <summary>
           /// Desc:字典编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true,ColumnName="dict_code")]
           public long DictCode {get;set;}

           /// <summary>
           /// Desc:字典排序
           /// Default:0
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="dict_sort")]           
           public int? DictSort {get;set;}

           /// <summary>
           /// Desc:字典标签
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="dict_label")]           
           public string DictLabel {get;set;}

           /// <summary>
           /// Desc:字典键值
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="dict_value")]           
           public string DictValue {get;set;}

           /// <summary>
           /// Desc:字典类型
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="dict_type")]           
           public string DictType {get;set;}

           /// <summary>
           /// Desc:样式属性（其他样式扩展）
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="css_class")]           
           public string CssClass {get;set;}

           /// <summary>
           /// Desc:表格回显样式
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="list_class")]           
           public string ListClass {get;set;}

           /// <summary>
           /// Desc:是否默认（Y是 N否）
           /// Default:N
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="is_default")]           
           public string IsDefault {get;set;}

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
