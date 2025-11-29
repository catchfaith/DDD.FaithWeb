using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace FaithBlog.Domain.Entities
{
    ///<summary>
    ///系统访问记录
    ///</summary>
    [SugarTable("sys_logininfor")]
    public partial class SysLogininfor
    {
           public SysLogininfor(){


           }
           /// <summary>
           /// Desc:访问ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true,ColumnName="info_id")]
           public long InfoId {get;set;}

           /// <summary>
           /// Desc:登录账号
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="login_name")]           
           public string LoginName {get;set;}

           /// <summary>
           /// Desc:登录IP地址
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="ipaddr")]           
           public string Ipaddr {get;set;}

           /// <summary>
           /// Desc:登录地点
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="login_location")]           
           public string LoginLocation {get;set;}

           /// <summary>
           /// Desc:浏览器类型
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="browser")]           
           public string Browser {get;set;}

           /// <summary>
           /// Desc:操作系统
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="os")]           
           public string Os {get;set;}

           /// <summary>
           /// Desc:登录状态（0成功 1失败）
           /// Default:0
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="status")]           
           public string Status {get;set;}

           /// <summary>
           /// Desc:提示消息
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="msg")]           
           public string Msg {get;set;}

           /// <summary>
           /// Desc:访问时间
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="login_time")]           
           public DateTime? LoginTime {get;set;}

    }
}
