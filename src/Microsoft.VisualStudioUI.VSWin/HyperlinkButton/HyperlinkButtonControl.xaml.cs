// Licensed to the .NET Foundation under one or more agreements. The .NET Foundation licenses this file to you under the MIT license. See the LICENSE.md file in the project root for more information.

using System.Windows.Controls;
using Microsoft.VisualStudio.Shell;

namespace Microsoft.VisualStudioUI.VSWin.HyperlinkButton
{
    /// <summary>
    /// Interaction logic for HyperlinkButton.xaml
    /// </summary>
    internal partial class HyperlinkButtonControl : UserControl
    {
        private readonly IHyperlinkButton _hyperlinkButton;

        public HyperlinkButtonControl(IHyperlinkButton hyperlinkButton)
        {
            InitializeComponent();

            _hyperlinkButton = hyperlinkButton;
            DataContext = hyperlinkButton;
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            string uri = _hyperlinkButton.Uri;
            if (! string.IsNullOrEmpty(uri))
                VsShellUtilities.OpenBrowser(uri);

            e.Handled = true;
        }
    }
}
