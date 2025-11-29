using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MyApp.Models
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("tb_home_title_model")]
    public partial class tb_home_title_model
    {
           public tb_home_title_model(){


           }
           /// <summary>
           /// Desc:主键id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string id {get;set;}

           /// <summary>
           /// Desc:标题id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string title_id {get;set;}

           /// <summary>
           /// Desc:模块文字
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string model_text {get;set;}

           /// <summary>
           /// Desc:模块类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? model_type {get;set;}

           /// <summary>
           /// Desc:模块跳转地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string model_url {get;set;}

           /// <summary>
           /// Desc:模块图片
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string model_img {get;set;}

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
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? is_del {get;set;}

    }
}
