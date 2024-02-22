using BlazorLearnWebApp.Entity;
using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;
using System.Security.Claims;

namespace BlazorLearnWebApp.Components.Layout
{
    public sealed partial class MainLayout
    {
        private bool IsOpen { get; set; }

        private string? Theme { get; set; }

        private string? LayoutClassString => CssBuilder.Default()
            .AddClass(Theme)
            .AddClass("is-fixed-tab", IsFixedTab)
            .Build();

        private IEnumerable<MenuItem>? Menus { get; set; }

        /// <summary>
        /// ���/���� �Ƿ�̶� TabHeader
        /// </summary>
        [Parameter]
        public bool IsFixedTab { get; set; }

        /// <summary>
        /// ���/���� �Ƿ�̶�ҳͷ
        /// </summary>
        [Parameter]
        public bool IsFixedHeader { get; set; } = true;

        /// <summary>
        /// ���/���� �Ƿ�̶�ҳ��
        /// </summary>
        [Parameter]
        public bool IsFixedFooter { get; set; } = true;

        /// <summary>
        /// ���/���� ������Ƿ�����
        /// </summary>
        [Parameter]
        public bool IsFullSide { get; set; } = true;

        /// <summary>
        /// ���/���� �Ƿ���ʾҳ��
        /// </summary>
        [Parameter]
        public bool ShowFooter { get; set; } = true;

        /// <summary>
        /// ���/���� �Ƿ������ǩģʽ
        /// </summary>
        [Parameter]
        public bool UseTabSet { get; set; } = true;

        private ClaimsPrincipal? _user;

        private List<string> _authUrl = new List<string>();

        /// <summary>
        /// OnInitializedAsync ����
        /// </summary>
        /// <returns></returns>
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();


            _user = (await _authenticationStateProvider.GetAuthenticationStateAsync()).User;

            if (_user == null)
            {
                return;
            }

            var roleId = _user.FindFirst(ClaimTypes.Role)?.Value;
            if (roleId == null)
            {
                return;
            }

            var role = RoleEntity.Where(x => x.Id == int.Parse(roleId)).IncludeMany(x => x.Menus).First();
            if (role == null || role.Menus == null)
            {
                return;
            }

            _authUrl = role.Menus.Select(x => x.Url!).ToList();

            Menus = CascadingMenu(role.Menus, 0);
        }

        private List<MenuItem> CascadingMenu(List<MenuEntity> menuEntities, int parentId) => menuEntities
            .Where(x => x.ParentId == parentId)
            .Select(x => new MenuItem { Text = x.MenuName, Items = CascadingMenu(menuEntities, x.Id), Icon = x.Icon, Url = x.Url }).ToList();

        /// <summary>
        /// �����������
        /// </summary>
        public void Update() => StateHasChanged();

        private void ToggleDrawer()
        {
            IsOpen = !IsOpen;
        }

        private Task<bool> OnAuthorizing(string url)
        {
            var localPath = new Uri(url).LocalPath;
            System.Console.WriteLine(localPath);
            if (_authUrl.Any(x => x == localPath))
            {
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }

    }
}