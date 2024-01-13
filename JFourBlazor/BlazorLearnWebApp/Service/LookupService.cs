using BlazorLearnWebApp.Entity;
using BootstrapBlazor.Components;

namespace BlazorLearnWebApp.Service
{
    public class LookupService : ILookupService
    {
        public IEnumerable<SelectedItem>? GetItemsByKey(string? key)
        {
            // 用户管理界面，绑定角色信息
            if (key == "role")
            {
                return RoleEntity.Select.ToList(x => new SelectedItem(x.Id.ToString(), x.RoleName!));
            }
            return null;
        }
    }
}
