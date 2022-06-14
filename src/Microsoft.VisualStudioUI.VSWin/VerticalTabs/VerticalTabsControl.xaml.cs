// Licensed to the .NET Foundation under one or more agreements. The .NET Foundation licenses this file to you under the MIT license. See the LICENSE.md file in the project root for more information.

using System.Windows.Controls;
using Microsoft.VisualStudio.PlatformUI.Packages.WhatsNew.UI;

namespace Microsoft.VisualStudioUI.VSWin.VerticalTabs
{
    public partial class VerticalTabsControl : UserControl
    {
        private readonly VerticalTabsViewModel? _viewModel;

        public VerticalTabsControl()
        {
            InitializeComponent();
            _viewModel = null;
        }

        internal VerticalTabsControl(VerticalTabsViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = viewModel;
        }
    }
}
