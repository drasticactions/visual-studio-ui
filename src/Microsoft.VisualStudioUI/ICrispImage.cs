using System.ComponentModel;
using Microsoft.ComponentModelEx;
using Microsoft.StandardUI;
using Microsoft.StandardUI.Controls;

namespace Microsoft.VisualStudioUI
{
    [StandardControl]
    public interface ICrispImage : IStandardControl
    {
        [DefaultValue("")]
        string KnownMoniker { get; set; }
        Microsoft.StandardUI.Color ImageBackgroundColor { get; set; }
    }
}
