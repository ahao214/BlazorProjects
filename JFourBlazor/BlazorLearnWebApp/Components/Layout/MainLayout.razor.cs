using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;

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

        /// <summary>
        /// OnInitializedAsync ����
        /// </summary>
        /// <returns></returns>
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            // ģ���첽��ȡ�˵�����
            await Task.Delay(10);

            Menus = new List<MenuItem>
        {
            new() { Text = "��ҳ", Icon = "fa-fw fa-solid fa-house", Url = "/" },
            new() { Text = "�û�����", Icon = "fa-fw fa-solid fa-desktop", Url = "user" },
            new() { Text = "ʾ����ҳ", Icon = "fa-fw fa-solid fa-laptop", Url = "layout-demo/text=Parameter1" }
        };
        }

        /// <summary>
        /// �����������
        /// </summary>
        public void Update() => StateHasChanged();

        private void ToggleDrawer()
        {
            IsOpen = !IsOpen;
        }


    }
}