using System;
using Foundation;
using Lottie.iOS;
using UIKit;

namespace Test.Lottie.iOS
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            // Perform any additional setup after loading the view, typically from a nib.
            CompatibleAnimation compatibleAnimation = new CompatibleAnimation("splash", NSBundle.MainBundle);
            CompatibleAnimationView animationView = new CompatibleAnimationView(new CoreGraphics.CGRect(0, 0, 200, 200))
            {
                CompatibleAnimation = compatibleAnimation
            };

            this.View.AddSubview(animationView);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
