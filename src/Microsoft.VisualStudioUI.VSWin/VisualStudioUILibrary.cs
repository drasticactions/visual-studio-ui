namespace Microsoft.VisualStudioUI.VSWin
{
    // TODO: This will be generated but for now must be updated manually
    public static class VisualStudioUILibrary
    {
        public static bool Initialized { get; private set; }

        public static void Initialize()
        {
            if (!Initialized)
            {
                VisualStudioUIFactory.HyperlinkButtonCreator = () => new Microsoft.VisualStudioUI.HyperlinkButton();
                VisualStudioUIFactory.ImageCreator = () => new Microsoft.VisualStudioUI.Image();
                VisualStudioUIFactory.CrispImageCreator = () => new Microsoft.VisualStudioUI.CrispImage();
            }
            Initialized = true;
        }
    }
}
