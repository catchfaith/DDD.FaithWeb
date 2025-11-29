using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace FaithBlog.Domain.Entities
{
    ///<summary>
    ///在线用户记录
    ///</summary>
    [SugarTable("sys_user_online")]
    public partial class SysUserOnline
    {
           public SysUserOnline(){


           }
           /// <summary>
           /// Desc:用户会话id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,ColumnName="sessionId")]
           public string Sessionid {get;set;}

           /// <summary>
           /// Desc:登录账号
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="login_name")]           
           public string LoginName {get;set;}

           /// <summary>
           /// Desc:部门名称
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="dept_name")]           
           public string DeptName {get;set;}

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
           /// Desc:在线状态on_line在线off_line离线
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="status")]           
           public string Status {get;set;}

           /// <summary>
           /// Desc:session创建时间
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="start_timestamp")]           
           public DateTime? StartTimestamp {get;set;}

           /// <summary>
           /// Desc:session最后访问时间
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="last_access_time")]           
           public DateTime? LastAccessTime {get;set;}

           /// <summary>
           /// Desc:超时时间，单位为分钟
           /// Default:0
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="expire_time")]           
           public int? ExpireTime {get;set;}

    }
}
