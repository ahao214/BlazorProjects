using System.ComponentModel;
using FreeSql.DataAnnotations;

namespace BlazorLearnWebApp.Entity
{
    [Description("角色菜单关系表")]
    public class RoleMenuEntity
    {

        [Description("角色ID")]
        [Column(IsPrimary = true)]
        public int RoleId { get; set; }

        [Description("菜单ID")]
        [Column(IsPrimary = true)]
        public int MenuId { get; set; }

    }
}
