using Microsoft.StandardUI;
using Microsoft.StandardUI.Controls;

namespace Microsoft.VisualStudioUI
{
    [StandardControl]
    public interface IDocLink : IStandardControl
    {
        string Url { get; set; }
    }
}
