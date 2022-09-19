using Microsoft.StandardUI;
using Microsoft.StandardUI.Controls;
using Microsoft.StandardUI.Wpf;
using Microsoft.VisualStudio.PlatformUI.Packages.WhatsNew.UI;
using Microsoft.VisualStudioUI.VSWin.VerticalTabs;

namespace Microsoft.VisualStudioUI
{
    public class VerticalTabsImplementation : StandardControlImplementation<IVerticalTabs>
    {
        public VerticalTabsImplementation(IVerticalTabs control) : base(control)
        {
        }

        public override IUIElement Build()
        {
            VerticalTabsControl tabsControl = new VerticalTabsControl(new VerticalTabsViewModel(Control));
            return new WrappedNativeUIElement(tabsControl);
        }
    }
}
