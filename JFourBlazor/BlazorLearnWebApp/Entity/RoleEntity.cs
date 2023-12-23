using FreeSql;
using System.ComponentModel;

namespace BlazorLearnWebApp.Entity
{
    [Description("角色信息表")]
    public class RoleEntity:BaseEntity<RoleEntity,int>
    {
        [Description("角色名")]
        /// <summary>
        /// 角色名
        /// </summary>
        public string? RoleName { get; set; }



    }
}
