using BlazorLearnWebApp.Attributes;
using FreeSql;
using FreeSql.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorLearnWebApp.Entity
{
    [Description("用户信息表")]
    public class UserEntity : BaseEntity<UserEntity, int>
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [Description("用户名")]
        [Required(ErrorMessage = "用户名不能为空")]
        [User(ErrorMessage = "用户名不能重复")]
        public string? UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Description("密码")]
        public string? Password { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [Description("用户昵称")]
        public string? NickName { get; set; }



        /// <summary>
        /// 角色ID
        /// </summary>
        [Description("角色ID")]
        public int RoleId { get; set; }

        [Navigate(nameof(RoleId))]
        public RoleEntity? Role { get; set; }
    }
}
