using System;
using Microsoft.StandardUI;

namespace Microsoft.VisualStudioUI
{
    // TODO: This will be generated but for now must be updated manually
    public static class VisualStudioUIStatics
    {
        private static Func<T> UnitializedCreator<T>() =>
            () => throw new CreatorNotInitializedException("VisualStudioUI");

        public static IHyperlinkButton HyperlinkButton() => HyperlinkButtonCreator();
        public static Func<IHyperlinkButton> HyperlinkButtonCreator { get; set; } = UnitializedCreator<IHyperlinkButton>();

        public static Func<IImage> ImageCreator { get; set; } = UnitializedCreator<IImage>();
        public static IImage Image() => ImageCreator();
    }
}
