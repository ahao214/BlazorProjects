using BlazorApp.Data;
using BlazorApp.Entity;
using BootstrapBlazor.Components;
using Furion.DynamicApiController;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;


namespace BlazorApp.Controller
{
    public class UserController : IDynamicApiController
    {
        public object PostLogin(LoginVo login)
        {
            if (UserEntity.Select.Where(x => x.UserName == login.UserName && x.Password == login.Password).Any())
            {
                var id = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                id.AddClaim(new Claim(ClaimTypes.Name, login.UserName!));

                Furion.App.HttpContext.SignInAsync(new ClaimsPrincipal(id));

                return new { Code = "200000", Message = "登录成功" };
            }

            return new { Code = "40100", Message = "用户名或密码错误" };
        }

    }
}
