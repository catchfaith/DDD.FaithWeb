using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace FaithBlog.Domain.Entities
{
    ///<summary>
    ///定时任务调度表
    ///</summary>
    [SugarTable("sys_job")]
    public partial class SysJob
    {
           public SysJob(){


           }
           /// <summary>
           /// Desc:任务ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true,ColumnName="job_id")]
           public long JobId {get;set;}

           /// <summary>
           /// Desc:任务名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,ColumnName="job_name")]
           public string JobName {get;set;}

           /// <summary>
           /// Desc:任务组名
           /// Default:DEFAULT
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,ColumnName="job_group")]
           public string JobGroup {get;set;}

           /// <summary>
           /// Desc:调用目标字符串
           /// Default:
           /// Nullable:False
           /// </summary>
           [SugarColumn(ColumnName="invoke_target")]           
           public string InvokeTarget {get;set;}

           /// <summary>
           /// Desc:cron执行表达式
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="cron_expression")]           
           public string CronExpression {get;set;}

           /// <summary>
           /// Desc:计划执行错误策略（1立即执行 2执行一次 3放弃执行）
           /// Default:3
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="misfire_policy")]           
           public string MisfirePolicy {get;set;}

           /// <summary>
           /// Desc:是否并发执行（0允许 1禁止）
           /// Default:1
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="concurrent")]           
           public string Concurrent {get;set;}

           /// <summary>
           /// Desc:状态（0正常 1暂停）
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
           /// Desc:备注信息
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="remark")]           
           public string Remark {get;set;}

    }
}
