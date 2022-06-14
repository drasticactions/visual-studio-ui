using System.ComponentModel;
using Microsoft.ComponentModelEx;
using Microsoft.StandardUI;
using Microsoft.StandardUI.Controls;

namespace Microsoft.VisualStudioUI
{
    [StandardControl]
    [ContentProperty(nameof(Tabs))]
    public interface IVerticalTabs : IStandardControl
    {
        IUICollection<IVerticalTab> Tabs { get; }
    }

    [UIObject]
    [ContentProperty(nameof(Title))]
    public interface IVerticalTab : IUIObject
    {
        [DefaultValue("")]
        string Title { get; set; }
    }
}
