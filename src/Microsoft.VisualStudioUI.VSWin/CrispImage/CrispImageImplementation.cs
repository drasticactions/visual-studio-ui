using Microsoft.StandardUI;
using Microsoft.StandardUI.Controls;
using Microsoft.StandardUI.Wpf;
using Microsoft.VisualStudioUI.VSWin.CrispImage;

namespace Microsoft.VisualStudioUI
{
    public class CrispImageImplementation : StandardControlImplementation<ICrispImage>
    {
        public CrispImageImplementation(ICrispImage control) : base(control)
        {
        }

        public override IUIElement Build()
        {
            return new NativeUIElement(new CrispImageControl(Control));
        }
    }
}
