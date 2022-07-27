using System;
using Microsoft.StandardUI;

namespace Microsoft.VisualStudioUI
{
    // TODO: This will be generated but for now must be updated manually
    public static class VisualStudioUIFactory
    {
        private static Func<T> UnitializedCreator<T>() =>
            () => throw new FactoryNotInitializedException("VisualStudioUI");

        public static Func<IHyperlinkButton> HyperlinkButtonCreator { get; set; } = UnitializedCreator<IHyperlinkButton>();
        public static Func<IImage> ImageCreator { get; set; } = UnitializedCreator<IImage>();
        public static Func<ICrispImage> CrispImageCreator { get; set; } = UnitializedCreator<ICrispImage>();
    }
}
