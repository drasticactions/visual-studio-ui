namespace Microsoft.VisualStudioUI.VSWin
{
    // TODO: This will be generated but for now must be updated manually
    public static class VisualStudioUILibrary
    {
        public static void Initialize()
        {
            VisualStudioUIFactory.HyperlinkButtonCreator = () => new Microsoft.VisualStudioUI.HyperlinkButton();
            VisualStudioUIFactory.ImageCreator = () => new Microsoft.VisualStudioUI.Image();
        }
    }
}
