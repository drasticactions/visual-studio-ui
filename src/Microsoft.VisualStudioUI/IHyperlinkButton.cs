using System.ComponentModel;
using Microsoft.ComponentModelEx;
using Microsoft.StandardUI;

namespace Microsoft.VisualStudioUI
{
    [ContentProperty(nameof(Label))]
    public interface IHyperlinkButton : IUIElement
    {
        [DefaultValue("")]
        string Label { get; set; }

        [DefaultValue(null)]
        string Uri { get; set; }
    }
}
