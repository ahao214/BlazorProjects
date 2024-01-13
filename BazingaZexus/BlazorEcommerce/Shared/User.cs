using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEcommerce.Shared
{
    /// <summary>
    /// 用户模型
    /// </summary>
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; } = string.Empty;

        public byte[] Password { get; set; }
        public byte[] PasswordSalt { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;


    }
}
