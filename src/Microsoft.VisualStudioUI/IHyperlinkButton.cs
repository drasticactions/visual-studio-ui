using Microsoft.StandardUI;
using Microsoft.StandardUI.Controls;

namespace Microsoft.VisualStudioUI
{
    [StandardControl]
    public interface IHyperlinkButton : IStandardControl
    {
        string Url { get; set; }
    }
}
