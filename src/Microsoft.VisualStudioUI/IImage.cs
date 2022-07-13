using System.ComponentModel;
using Microsoft.StandardUI;
using Microsoft.StandardUI.Controls;

namespace Microsoft.VisualStudioUI
{
    [StandardControl]
    public interface IImage : IStandardControl
    {
        [DefaultValue("")]
        string Source { get; set; }
    }
}
