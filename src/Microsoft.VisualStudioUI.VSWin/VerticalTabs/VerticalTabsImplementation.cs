using Microsoft.StandardUI;
using Microsoft.StandardUI.Controls;
using Microsoft.StandardUI.Wpf;
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
            return new NativeUIElement(new VerticalTabsControl());
        }
    }
}
