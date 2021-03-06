using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using ReefAngel.Interface;

namespace ReefAngel
{
    public partial class FirstViewController : UIViewController
    {
        static bool UserInterfaceIdiomIsPhone
        {
            get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
        }

        public FirstViewController()
			: base(UserInterfaceIdiomIsPhone ? "FirstViewController_iPhone" : "FirstViewController_iPad", null)
        {
            this.Title = NSBundle.MainBundle.LocalizedString("Status", "Status");
            this.TabBarItem.Image = UIImage.FromBundle("first");
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();
			
            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override bool ShouldAutorotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation)
        {
            // Return true for supported orientations
            if (UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone)
            {
                return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
            }
            else
            {
                return true;
            }
        }

        partial void actnButtonClick(MonoTouch.UIKit.UIButton sender)
        {
            var reefAngelClientFactory = new ReefAngelClientFactory();
            var uri = new Uri("");
            var reefAngelClient = reefAngelClientFactory.CreateReefAngelClient(uri, "test");
            reefAngelClient.FeedModeController.Run();
        }
    }
}
