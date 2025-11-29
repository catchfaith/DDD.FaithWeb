using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace FaithBlog.Domain.Entities
{
    ///<summary>
    ///操作日志记录
    ///</summary>
    [SugarTable("sys_oper_log")]
    public partial class SysOperLog
    {
           public SysOperLog(){


           }
           /// <summary>
           /// Desc:日志主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true,ColumnName="oper_id")]
           public long OperId {get;set;}

           /// <summary>
           /// Desc:模块标题
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="title")]           
           public string Title {get;set;}

           /// <summary>
           /// Desc:业务类型（0其它 1新增 2修改 3删除）
           /// Default:0
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="business_type")]           
           public int? BusinessType {get;set;}

           /// <summary>
           /// Desc:方法名称
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="method")]           
           public string Method {get;set;}

           /// <summary>
           /// Desc:请求方式
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="request_method")]           
           public string RequestMethod {get;set;}

           /// <summary>
           /// Desc:操作类别（0其它 1后台用户 2手机端用户）
           /// Default:0
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="operator_type")]           
           public int? OperatorType {get;set;}

           /// <summary>
           /// Desc:操作人员
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="oper_name")]           
           public string OperName {get;set;}

           /// <summary>
           /// Desc:部门名称
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="dept_name")]           
           public string DeptName {get;set;}

           /// <summary>
           /// Desc:请求URL
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="oper_url")]           
           public string OperUrl {get;set;}

           /// <summary>
           /// Desc:主机地址
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="oper_ip")]           
           public string OperIp {get;set;}

           /// <summary>
           /// Desc:操作地点
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="oper_location")]           
           public string OperLocation {get;set;}

           /// <summary>
           /// Desc:请求参数
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="oper_param")]           
           public string OperParam {get;set;}

           /// <summary>
           /// Desc:返回参数
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="json_result")]           
           public string JsonResult {get;set;}

           /// <summary>
           /// Desc:操作状态（0正常 1异常）
           /// Default:0
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="status")]           
           public int? Status {get;set;}

           /// <summary>
           /// Desc:错误消息
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="error_msg")]           
           public string ErrorMsg {get;set;}

           /// <summary>
           /// Desc:操作时间
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="oper_time")]           
           public DateTime? OperTime {get;set;}

           /// <summary>
           /// Desc:消耗时间
           /// Default:0
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="cost_time")]           
           public long? CostTime {get;set;}

    }
}
