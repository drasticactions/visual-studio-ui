using Microsoft.StandardUI;
using Microsoft.StandardUI.Controls;
using Microsoft.StandardUI.Wpf;
using Microsoft.VisualStudioUI.VSWin.HyperlinkButton;

namespace Microsoft.VisualStudioUI
{
    public class HyperlinkButtonImplementation : StandardControlImplementation<IHyperlinkButton>
    {
        public HyperlinkButtonImplementation(IHyperlinkButton control) : base(control)
        {
        }

        public override IUIElement Build()
        {
            return new NativeUIElement(new HyperlinkButtonControl(Control));
        }
    }
}
