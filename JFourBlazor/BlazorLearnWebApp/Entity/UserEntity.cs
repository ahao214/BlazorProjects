using FreeSql;
using System.ComponentModel;

namespace BlazorLearnWebApp.Entity
{
    [Description("用户信息表")]
    public class UserEntity:BaseEntity<UserEntity,int>
    {
        [Description("用户名称")]
        /// <summary>
        /// 用户名称
        /// </summary>
        public string? UserName { get; set; }
        [Description("用户密码")]
        /// <summary>
        /// 用户密码
        /// </summary>
        public string? Password { get; set; }
        [Description("用户昵称")]
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string? NickName { get; set; }
        
    }
}
