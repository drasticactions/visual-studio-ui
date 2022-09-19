using System.Windows.Documents;
using System;
using Microsoft.StandardUI;
using Microsoft.VisualStudio.Shell;

namespace Microsoft.VisualStudioUI.Wpf
{
    [WpfStandardUIElement(typeof(IHyperlinkButton))]
    public partial class HyperlinkButton : System.Windows.Controls.TextBlock, IHyperlinkButton
    {
        private readonly Hyperlink _hyperlink;

        public HyperlinkButton()
        {
            _hyperlink = new Hyperlink()
            {
                NavigateUri = new Uri("http://somesite.example")
            };
            _hyperlink.Inlines.Add("some site");
            _hyperlink.RequestNavigate += Hyperlink_RequestNavigate;

            Inlines.Add(_hyperlink);

#if false
    < Hyperlink Style = "{DynamicResource {x:Static vsfx:VsResourceKeys.ThemedDialogHyperlinkStyleKey}}" NavigateUri = "" RequestNavigate = "Hyperlink_RequestNavigate" >
        < Run Text = "{Binding Label}" />
    </ Hyperlink >
#endif
        }

#if false
        public void Build()
        {
            this.Style = null;
            RequestNavigate += ; 
        }
#endif

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            string uri = Uri;
            if (!string.IsNullOrEmpty(uri))
                VsShellUtilities.OpenBrowser(uri);

            e.Handled = true;
        }
    }
}
