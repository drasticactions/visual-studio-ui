using System.ComponentModel;
using Microsoft.ComponentModelEx;
using Microsoft.StandardUI;
using Microsoft.StandardUI.Controls;

namespace Microsoft.VisualStudioUI
{
    [StandardControl]
    [ContentProperty(nameof(Label))]
    public interface IHyperlinkButton : IStandardControl
    {
        [DefaultValue("")]
        string Label { get; set; }

        [DefaultValue(null)]
        string Uri { get; set; }
    }
}
