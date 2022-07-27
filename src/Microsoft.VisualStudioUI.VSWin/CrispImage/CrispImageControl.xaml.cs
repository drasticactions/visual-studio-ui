// Licensed to the .NET Foundation under one or more agreements. The .NET Foundation licenses this file to you under the MIT license. See the LICENSE.md file in the project root for more information.

using System.Windows.Controls;
using Microsoft.VisualStudio.Imaging.Interop;
using Microsoft.VisualStudio.Imaging;

namespace Microsoft.VisualStudioUI.VSWin.CrispImage
{
    /// <summary>
    /// Interaction logic for CrispImageControl.xaml
    /// </summary>
    public partial class CrispImageControl : UserControl
    {
        private readonly ICrispImage _crispImage;
        public CrispImageControl(ICrispImage crispImage)
        {
            InitializeComponent();
            _crispImage = crispImage;
            string monikerString = (string)typeof(KnownMonikers).GetField(crispImage.KnownMoniker).GetValue(null);
            _ = ImagingUtilities.TryParseImageMoniker(monikerString, out ImageMoniker moniker);
            TempData temp = new TempData(moniker);
            DataContext = temp;
        }
    }

    public class TempData
    {
        public TempData(ImageMoniker knownMoniker)
        {
            KnownMoniker = knownMoniker;
        }

        public ImageMoniker KnownMoniker { get; set; }
    }
}
