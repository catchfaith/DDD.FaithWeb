using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace FaithBlog.Domain.Entities
{
    ///<summary>
    ///定时任务调度日志表
    ///</summary>
    [SugarTable("sys_job_log")]
    public partial class SysJobLog
    {
           public SysJobLog(){


           }
           /// <summary>
           /// Desc:任务日志ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true,ColumnName="job_log_id")]
           public long JobLogId {get;set;}

           /// <summary>
           /// Desc:任务名称
           /// Default:
           /// Nullable:False
           /// </summary>
           [SugarColumn(ColumnName="job_name")]           
           public string JobName {get;set;}

           /// <summary>
           /// Desc:任务组名
           /// Default:
           /// Nullable:False
           /// </summary>
           [SugarColumn(ColumnName="job_group")]           
           public string JobGroup {get;set;}

           /// <summary>
           /// Desc:调用目标字符串
           /// Default:
           /// Nullable:False
           /// </summary>
           [SugarColumn(ColumnName="invoke_target")]           
           public string InvokeTarget {get;set;}

           /// <summary>
           /// Desc:日志信息
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="job_message")]           
           public string JobMessage {get;set;}

           /// <summary>
           /// Desc:执行状态（0正常 1失败）
           /// Default:0
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="status")]           
           public string Status {get;set;}

           /// <summary>
           /// Desc:异常信息
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="exception_info")]           
           public string ExceptionInfo {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="create_time")]           
           public DateTime? CreateTime {get;set;}

    }
}
