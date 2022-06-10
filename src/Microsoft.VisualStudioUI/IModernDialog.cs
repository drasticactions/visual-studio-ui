using Microsoft.StandardUI;
using Microsoft.StandardUI.Controls;

namespace Microsoft.VisualStudioUI
{
    [StandardControl]
    public interface IModernDialog : IStandardControl
    {
        string Title { get; set; }

        IUIElement Content { get; set; }
    }
}
