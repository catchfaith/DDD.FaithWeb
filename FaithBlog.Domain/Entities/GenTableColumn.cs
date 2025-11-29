using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace FaithBlog.Domain.Entities
{
    ///<summary>
    ///代码生成业务表字段
    ///</summary>
    [SugarTable("gen_table_column")]
    public partial class GenTableColumn
    {
           public GenTableColumn(){


           }
           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true,ColumnName="column_id")]
           public long ColumnId {get;set;}

           /// <summary>
           /// Desc:归属表编号
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="table_id")]           
           public long? TableId {get;set;}

           /// <summary>
           /// Desc:列名称
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="column_name")]           
           public string ColumnName {get;set;}

           /// <summary>
           /// Desc:列描述
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="column_comment")]           
           public string ColumnComment {get;set;}

           /// <summary>
           /// Desc:列类型
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="column_type")]           
           public string ColumnType {get;set;}

           /// <summary>
           /// Desc:JAVA类型
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="java_type")]           
           public string JavaType {get;set;}

           /// <summary>
           /// Desc:JAVA字段名
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="java_field")]           
           public string JavaField {get;set;}

           /// <summary>
           /// Desc:是否主键（1是）
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="is_pk")]           
           public string IsPk {get;set;}

           /// <summary>
           /// Desc:是否自增（1是）
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="is_increment")]           
           public string IsIncrement {get;set;}

           /// <summary>
           /// Desc:是否必填（1是）
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="is_required")]           
           public string IsRequired {get;set;}

           /// <summary>
           /// Desc:是否为插入字段（1是）
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="is_insert")]           
           public string IsInsert {get;set;}

           /// <summary>
           /// Desc:是否编辑字段（1是）
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="is_edit")]           
           public string IsEdit {get;set;}

           /// <summary>
           /// Desc:是否列表字段（1是）
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="is_list")]           
           public string IsList {get;set;}

           /// <summary>
           /// Desc:是否查询字段（1是）
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="is_query")]           
           public string IsQuery {get;set;}

           /// <summary>
           /// Desc:查询方式（等于、不等于、大于、小于、范围）
           /// Default:EQ
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="query_type")]           
           public string QueryType {get;set;}

           /// <summary>
           /// Desc:显示类型（文本框、文本域、下拉框、复选框、单选框、日期控件）
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="html_type")]           
           public string HtmlType {get;set;}

           /// <summary>
           /// Desc:字典类型
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="dict_type")]           
           public string DictType {get;set;}

           /// <summary>
           /// Desc:排序
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="sort")]           
           public int? Sort {get;set;}

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
