using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.VisualStudioUI;

namespace Microsoft.VisualStudio.PlatformUI.Packages.WhatsNew.UI
{
    internal class VerticalTabsViewModel : INotifyPropertyChanged
    {
        // Not displayed to user, must not be localized, used in telemetry
        private readonly IVerticalTabs? _control;

        public event PropertyChangedEventHandler PropertyChanged;

        public VerticalTabsViewModel(IVerticalTabs control)
        {
            _control = control;
        }

        public void SelectTab(string featureName)
        {
#if false
            if (this.featuresByName.TryGetValue(featureName, out IWhatsNewFeature feature))
            {
                this.SelectedTab = feature;
            }
            else
            {
                FeatureNotFoundError(featureName);
            }
#endif
        }

        public IList<IVerticalTab> Tabs => _control.Tabs;

        private IVerticalTab? _selectedTab;
        public IVerticalTab SelectedTab
        {
            get => _selectedTab;
            set
            {
#if false
                Requires.NotNull(value, nameof(value));
                var previous = _selectedTab;
                if (SetProperty(ref _selectedTab, value))
                {
                    SelectedTab.IsSelected = true;
                    if (previous != null) // This happens on the call from the constructor.  No previous, so nothing to unselect.
                        previous.IsSelected = false;

                    var selectedEvent = new TelemetryEvent(TelemetryConstants.WhatsNewPageFeaturedSelectedEventName);
                    selectedEvent.Properties.Add(TelemetryConstants.WhatsNewPageFeaturePropertyName, value.FeatureContent.Name);
                    this.telemetrySession.PostEvent(selectedEvent);
                }
#endif
            }
        }
    }
}
