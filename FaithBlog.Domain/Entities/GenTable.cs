using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace FaithBlog.Domain.Entities
{
    ///<summary>
    ///代码生成业务表
    ///</summary>
    [SugarTable("gen_table")]
    public partial class GenTable
    {
           public GenTable(){


           }
           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true,ColumnName="table_id")]
           public long TableId {get;set;}

           /// <summary>
           /// Desc:表名称
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="table_name")]           
           public string TableName {get;set;}

           /// <summary>
           /// Desc:表描述
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="table_comment")]           
           public string TableComment {get;set;}

           /// <summary>
           /// Desc:关联子表的表名
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="sub_table_name")]           
           public string SubTableName {get;set;}

           /// <summary>
           /// Desc:子表关联的外键名
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="sub_table_fk_name")]           
           public string SubTableFkName {get;set;}

           /// <summary>
           /// Desc:实体类名称
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="class_name")]           
           public string ClassName {get;set;}

           /// <summary>
           /// Desc:使用的模板（crud单表操作 tree树表操作 sub主子表操作）
           /// Default:crud
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="tpl_category")]           
           public string TplCategory {get;set;}

           /// <summary>
           /// Desc:生成包路径
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="package_name")]           
           public string PackageName {get;set;}

           /// <summary>
           /// Desc:生成模块名
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="module_name")]           
           public string ModuleName {get;set;}

           /// <summary>
           /// Desc:生成业务名
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="business_name")]           
           public string BusinessName {get;set;}

           /// <summary>
           /// Desc:生成功能名
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="function_name")]           
           public string FunctionName {get;set;}

           /// <summary>
           /// Desc:生成功能作者
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="function_author")]           
           public string FunctionAuthor {get;set;}

           /// <summary>
           /// Desc:表单布局（单列 双列 三列）
           /// Default:1
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="form_col_num")]           
           public int? FormColNum {get;set;}

           /// <summary>
           /// Desc:生成代码方式（0zip压缩包 1自定义路径）
           /// Default:0
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="gen_type")]           
           public string GenType {get;set;}

           /// <summary>
           /// Desc:生成路径（不填默认项目路径）
           /// Default:/
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="gen_path")]           
           public string GenPath {get;set;}

           /// <summary>
           /// Desc:其它生成选项
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="options")]           
           public string Options {get;set;}

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
