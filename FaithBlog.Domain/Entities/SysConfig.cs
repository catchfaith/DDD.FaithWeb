using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace FaithBlog.Domain.Entities
{
    ///<summary>
    ///参数配置表
    ///</summary>
    [SugarTable("sys_config")]
    public partial class SysConfig
    {
           public SysConfig(){


           }
           /// <summary>
           /// Desc:参数主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true,ColumnName="config_id")]
           public int ConfigId {get;set;}

           /// <summary>
           /// Desc:参数名称
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="config_name")]           
           public string ConfigName {get;set;}

           /// <summary>
           /// Desc:参数键名
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="config_key")]           
           public string ConfigKey {get;set;}

           /// <summary>
           /// Desc:参数键值
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="config_value")]           
           public string ConfigValue {get;set;}

           /// <summary>
           /// Desc:系统内置（Y是 N否）
           /// Default:N
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="config_type")]           
           public string ConfigType {get;set;}

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
