using Microsoft.VisualStudioUI.Options;
using Microsoft.VisualStudioUI.VSMac.Options;
using StandaloneApp.VSMacUI;

// This is the main entry point of the application.
OptionFactoryPlatform.Initialize(new OptionFactoryVSMac());
NSApplication.Init();

NSApplication.SharedApplication.Delegate = new AppDelegate();

NSApplication.Main(args);
