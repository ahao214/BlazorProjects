using BlazorLearnWebApp.Entity;
using BlazorLearnWebApp.Vo;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Serialization;

namespace BlazorLearnWebApp.Controllers
{
    [ApiController]
    [Route("/api/[Controller]/[action]")]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        public object Login([FromBody] LoginVo loginVo)
        {
            var user = UserEntity.Where(x => x.UserName == loginVo.UserName && x.Password == loginVo.Password).First();
            if (user == null)
            {
                return new { Code = 50000, Message = "用户名或密码错误" };
            }
            return new { Code = 20000, Message = "登录成功" };
        }
    }
}
