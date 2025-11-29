using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MyApp.Models
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("tb_home_title")]
    public partial class tb_home_title
    {
           public tb_home_title(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string id {get;set;}

           /// <summary>
           /// Desc:标题
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string title {get;set;}

           /// <summary>
           /// Desc:标题类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? title_type {get;set;}

           /// <summary>
           /// Desc:标题图片
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string tltle_img {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? is_del {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? create_time {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string create_by {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? update_time {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string update_by {get;set;}

           /// <summary>
           /// Desc:标题跳转路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string title_url {get;set;}

    }
}
