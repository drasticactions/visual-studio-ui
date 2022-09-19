namespace Microsoft.VisualStudioUI.Wpf
{
    // TODO: This will be generated but for now must be updated manually
    public static class VisualStudioUILibrary
    {
        public static bool Initialized { get; private set; }

        public static void Initialize()
        {
            if (!Initialized)
            {
                VisualStudioUIFactory.HyperlinkButtonCreator = () => new HyperlinkButton();
                VisualStudioUIFactory.ImageCreator = () => new Image();
                VisualStudioUIFactory.CrispImageCreator = () => new CrispImage();
            }
            Initialized = true;
        }
    }
}
