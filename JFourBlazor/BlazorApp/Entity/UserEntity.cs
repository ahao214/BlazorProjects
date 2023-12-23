using FreeSql;
using System.ComponentModel;

namespace BlazorApp.Entity
{
    [Description("用户信息表")]
    public class UserEntity : BaseEntity<UserEntity, int>
    {
        [Description("用户名")]
        public string? UserName { get; set; }

        [Description("密码")]
        public string? Password { get; set; }

        [Description("昵称")]
        public string? NickName { get; set; }

    }
}
