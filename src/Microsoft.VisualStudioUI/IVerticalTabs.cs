using Microsoft.StandardUI;
using Microsoft.StandardUI.Controls;

namespace Microsoft.VisualStudioUI
{
    [StandardControl]
    public interface IVerticalTabs : IStandardControl
    {
        IUICollection<IVerticalTabs> Tabs { get; }
    }

    public interface IIVerticalTab : IUIObject
    {
        string Title { get; set; }
    }
}
