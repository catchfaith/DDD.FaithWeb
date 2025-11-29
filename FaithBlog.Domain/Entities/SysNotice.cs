using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace FaithBlog.Domain.Entities
{
    ///<summary>
    ///通知公告表
    ///</summary>
    [SugarTable("sys_notice")]
    public partial class SysNotice
    {
           public SysNotice(){


           }
           /// <summary>
           /// Desc:公告ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true,ColumnName="notice_id")]
           public int NoticeId {get;set;}

           /// <summary>
           /// Desc:公告标题
           /// Default:
           /// Nullable:False
           /// </summary>
           [SugarColumn(ColumnName="notice_title")]           
           public string NoticeTitle {get;set;}

           /// <summary>
           /// Desc:公告类型（1通知 2公告）
           /// Default:
           /// Nullable:False
           /// </summary>
           [SugarColumn(ColumnName="notice_type")]           
           public string NoticeType {get;set;}

           /// <summary>
           /// Desc:公告内容
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="notice_content")]           
           public byte[] NoticeContent {get;set;}

           /// <summary>
           /// Desc:公告状态（0正常 1关闭）
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
