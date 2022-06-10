using System;
using Microsoft.StandardUI;
using Microsoft.StandardUI.Controls;

namespace Microsoft.VisualStudioUI
{
    [StandardControl]
    public interface IImage : IStandardControl
    {
        string ImageMoniker { get; set; }
    }
}
