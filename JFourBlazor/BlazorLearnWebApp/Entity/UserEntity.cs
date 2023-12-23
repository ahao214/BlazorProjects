using FreeSql;
using System.ComponentModel;

namespace BlazorLearnWebApp.Entity
{
    [Description("用户信息表")]
    public class UserEntity:BaseEntity<UserEntity,int>
    {
        /// <summary>
        /// 用户名称
        /// </summary>
        public string? UserName { get; set; }    
        /// <summary>
        /// 用户密码
        /// </summary>
        public string? Password { get; set; }
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string? NickName { get; set; }
        
    }
}
