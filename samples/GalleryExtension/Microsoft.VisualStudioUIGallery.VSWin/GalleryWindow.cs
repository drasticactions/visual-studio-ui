// Licensed to the .NET Foundation under one or more agreements. The .NET Foundation licenses this file to you under the MIT license. See the LICENSE.md file in the project root for more information.

using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace Microsoft.VisualStudioUIGallery.VSWin
{
    /// <summary>
    /// This class implements the tool window exposed by this package and hosts a user control.
    /// </summary>
    /// <remarks>
    /// In Visual Studio tool windows are composed of a frame (implemented by the shell) and a pane,
    /// usually implemented by the package implementer.
    /// <para>
    /// This class derives from the ToolWindowPane class provided from the MPF in order to use its
    /// implementation of the IVsUIElementPane interface.
    /// </para>
    /// </remarks>
    [Guid("14e2f16d-81bb-4b10-a35e-e5a4c02d0a4d")]
    public class GalleryWindow : ToolWindowPane
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GalleryWindow"/> class.
        /// </summary>
        public GalleryWindow() : base(null)
        {
            this.Caption = "Visual Studio UI Gallery";

            // This is the user control hosted by the tool window; Note that, even if this class implements IDisposable,
            // we are not calling Dispose on this object. This is because ToolWindowPane calls Dispose on
            // the object returned by the Content property.
            this.Content = new GalleryWindowControl();
        }
    }
}
