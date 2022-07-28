// Licensed to the .NET Foundation under one or more agreements. The .NET Foundation licenses this file to you under the MIT license. See the LICENSE.md file in the project root for more information.

using System.Windows.Controls;
using Microsoft.VisualStudio.Imaging.Interop;
using Microsoft.VisualStudio.Imaging;
using Microsoft.StandardUI.Wpf;
using System.Windows.Media;

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
            string monikerString = (string)typeof(KnownImageMonikers).GetField(crispImage.KnownMoniker).GetValue(null);
            _ = ImagingUtilities.TryParseImageMoniker(monikerString, out ImageMoniker moniker);
            Color color = ColorExtensions.ToWpfColor(crispImage.ImageBackgroundColor);
            CrispImageData data = new CrispImageData(moniker, crispImage.Width, crispImage.Height, color);
            DataContext = data;
        }
    }

    public class CrispImageData
    {
        public CrispImageData(ImageMoniker knownMoniker, double width, double height, Color imageBackgroundColor)
        {
            KnownMoniker = knownMoniker;
            Width = width;
            Height = height;
            ImageBackgroundColor = imageBackgroundColor;
        }

        public ImageMoniker KnownMoniker { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public Color ImageBackgroundColor { get; set; }
    }
}
