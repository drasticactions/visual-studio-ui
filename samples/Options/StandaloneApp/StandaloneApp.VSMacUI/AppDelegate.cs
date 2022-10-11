namespace StandaloneApp.VSMacUI;

[Register ("AppDelegate")]
public class AppDelegate : NSApplicationDelegate {

    private MainWindowController? mainWindowController;

    public override void DidFinishLaunching (NSNotification notification)
	{
        this.mainWindowController = new MainWindowController();
        this.mainWindowController.Window.MakeKeyAndOrderFront(this);
    }

	public override void WillTerminate (NSNotification notification)
	{
		// Insert code here to tear down your application
	}
}
