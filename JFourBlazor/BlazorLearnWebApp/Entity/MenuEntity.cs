using FreeSql;
using System.ComponentModel;

namespace BlazorLearnWebApp.Entity
{
    [Description("菜单信息表")]
    public class MenuEntity:BaseEntity<MenuEntity,int>
    {
        [Description("菜单名称")]
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string? MenuName { get; set; }

        [Description("URL链接")]
        /// <summary>
        /// URL链接
        /// </summary>
        public string? Url { get; set;}

        [Description("菜单图标")]
        /// <summary>
        /// 菜单图标
        /// </summary>
        public string? Icon {  get; set;}

        [Description("父级菜单ID")]
        /// <summary>
        /// 父级菜单ID
        /// </summary>
        public int ParentId { get; set;}

    }
}
