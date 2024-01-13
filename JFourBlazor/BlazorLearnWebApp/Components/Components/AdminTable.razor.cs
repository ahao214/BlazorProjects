using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace BlazorLearnWebApp.Components.Components
{
    [CascadingTypeParameter(nameof(TItem))]
    public partial class AdminTable<TItem> where TItem : class, new()
    {
        [NotNull]
        [Parameter]
        public RenderFragment<TItem>? TableColumns { get; set; }

        [Parameter]
        public Func<TItem, ItemChangedType, Task<bool>>? OnSaveAsync { get; set; }

        [Parameter]
        public Func<IEnumerable<TItem>, Task<bool>>? OnDeleteAsync { get; set; }

        [Parameter]
        public bool IsTree { get; set; }

        [Parameter]
        public Func <IEnumerable<TItem>, Task<IEnumerable<TableTreeNode<TItem>>>>? TreeNodeConverter { get; set; }

        [Parameter]
        public Func<TItem, bool>? ShowExtendEditButtonCallback { get; set; }

        [Parameter]
        public Func<TItem, bool>? ShowExtendDeleteButtonCallback { get; set; }

        [Parameter]
        public RenderFragment<TItem>? BeforeRowButtonTemplate { get; set; }

        [Parameter]
        public RenderFragment<TItem>? RowButtonTemplate { get; set; }




    }
}