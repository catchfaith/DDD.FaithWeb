using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace FaithBlog.Domain.Entities
{
    ///<summary>
    ///菜单权限表
    ///</summary>
    [SugarTable("sys_menu")]
    public partial class SysMenu
    {
           public SysMenu(){


           }
           /// <summary>
           /// Desc:菜单ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true,ColumnName="menu_id")]
           public long MenuId {get;set;}

           /// <summary>
           /// Desc:菜单名称
           /// Default:
           /// Nullable:False
           /// </summary>
           [SugarColumn(ColumnName="menu_name")]           
           public string MenuName {get;set;}

           /// <summary>
           /// Desc:父菜单ID
           /// Default:0
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="parent_id")]           
           public long? ParentId {get;set;}

           /// <summary>
           /// Desc:显示顺序
           /// Default:0
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="order_num")]           
           public int? OrderNum {get;set;}

           /// <summary>
           /// Desc:请求地址
           /// Default:#
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="url")]           
           public string Url {get;set;}

           /// <summary>
           /// Desc:打开方式（menuItem页签 menuBlank新窗口）
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="target")]           
           public string Target {get;set;}

           /// <summary>
           /// Desc:菜单类型（M目录 C菜单 F按钮）
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="menu_type")]           
           public string MenuType {get;set;}

           /// <summary>
           /// Desc:菜单状态（0显示 1隐藏）
           /// Default:0
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="visible")]           
           public string Visible {get;set;}

           /// <summary>
           /// Desc:是否刷新（0刷新 1不刷新）
           /// Default:1
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="is_refresh")]           
           public string IsRefresh {get;set;}

           /// <summary>
           /// Desc:权限标识
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="perms")]           
           public string Perms {get;set;}

           /// <summary>
           /// Desc:菜单图标
           /// Default:#
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnName="icon")]           
           public string Icon {get;set;}

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
