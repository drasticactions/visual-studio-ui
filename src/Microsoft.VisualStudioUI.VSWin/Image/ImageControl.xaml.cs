// Licensed to the .NET Foundation under one or more agreements. The .NET Foundation licenses this file to you under the MIT license. See the LICENSE.md file in the project root for more information.

using System.Windows.Controls;

namespace Microsoft.VisualStudioUI.VSWin.Image
{
    /// <summary>
    /// Interaction logic for ImageControl.xaml
    /// </summary>
    public partial class ImageControl : UserControl
    {
        private readonly IImage _image;

        public ImageControl(IImage image)
        {
            InitializeComponent();

            _image = image;
            DataContext = image;
        }
    }
}
