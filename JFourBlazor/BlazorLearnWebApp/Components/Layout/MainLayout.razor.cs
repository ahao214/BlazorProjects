using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;

namespace BlazorLearnWebApp.Components.Layout
{
    public partial class MainLayout<TItem> where TItem : class, new()
    {

        private bool IsOpen { get; set; }

        private string? Theme { get; set; }

        private string? LayoutClassString => CssBuilder.Default()
            .AddClass(Theme)
            .AddClass("is-fixed-tab", IsFixedTab)
            .Build();

        private IEnumerable<MenuItem>? Menus { get; set; }

        [Parameter]
        public bool IsFixedTab { get; set; }
        [Parameter]
        public bool IsFixedHeader { get; set; } = true;
        [Parameter]
        public bool IsFixedFooter { get; set; } = true;
        [Parameter]
        public bool IsFullSide { get; set; } = true;

        [Parameter]
        public bool ShowFooter { get; set; } = true;

        [Parameter]
        public bool UseTabSet { get; set; } = true;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            await Task.Delay(10);

            Menus = new List<MenuItem>
            {
                new (){Text="首页",Icon="fa-fw fa-solid fa-house",Url="/"},
                new (){Text="用户管理",Icon="fa-fw fa-solid fa-desktop",Url="user"},
new (){Text="示例网页",Icon="fa-fw fa-solid fa-laptop",Url="layout-demo/text=Parameter1"},
            };

        }

        public void Update() => StateHasChanged();

        private void ToggleDrawer()
        {
            IsOpen = !IsOpen;
        }
    }
}