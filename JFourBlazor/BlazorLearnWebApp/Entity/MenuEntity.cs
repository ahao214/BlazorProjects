using FreeSql;
using FreeSql.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorLearnWebApp.Entity
{
    [Description("菜单表")]
    public class MenuEntity:BaseEntity<MenuEntity,int>
    {
        /// <summary>
        /// 菜单名
        /// </summary>
        [Description("菜单名")]
        [Required(ErrorMessage ="菜单名不能为空")]
        public string? MenuName { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [Description("URL")]
        [Required(ErrorMessage = "Url不能为空")]
        public string? Url { get; set;}

        /// <summary>
        /// 图标
        /// </summary>
        [Description("图标")]
        [Required(ErrorMessage = "图标不能为空")]
        public string? Icon {  get; set;}

        /// <summary>
        /// 父级菜单ID
        /// </summary>
        [Description("父级菜单ID")]
        public int ParentId { get; set;}

        [Navigate(nameof(ParentId))]
        public MenuEntity? Parent { get; set;}

        [Navigate(nameof(ParentId))]
        public List <MenuEntity>? Children { get; set; }

        [Navigate(ManyToMany =typeof(RoleMenuEntity))]
        public List <RoleEntity>? Roles { get; set;}

    }
}
