using Microsoft.StandardUI;
using Microsoft.StandardUI.Controls;
using Microsoft.StandardUI.Wpf;
using Microsoft.VisualStudioUI.VSWin.Image;

namespace Microsoft.VisualStudioUI
{
    public class ImageImplementation : StandardControlImplementation<IImage>
    {
        public ImageImplementation(IImage control) : base(control)
        {
        }

        public override IUIElement Build()
        {
            return new NativeUIElement(new ImageControl(Control));
        }
    }
}
