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
            this.View.BackgroundColor = UIColor.Black;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            var cAnimation = new CompatibleAnimation("splash", NSBundle.MainBundle);

            var animView = new CompatibleAnimationView()
            {
                CompatibleAnimation = cAnimation,
            };
            animView.LoopAnimationCount = -1; // Allow loop
            animView.Frame = new CoreGraphics.CGRect(View.Frame.Width / 2, View.Frame.Height / 2, 200, 200);
            animView.Center = View.ConvertPointFromView(View.Center, animView);

            animView.TranslatesAutoresizingMaskIntoConstraints = false;

            this.View.AddSubview(animView);

            animView.TopAnchor.ConstraintEqualTo(View.TopAnchor).Active = true;

            animView.TrailingAnchor.ConstraintEqualTo(View.TrailingAnchor).Active = true;
            animView.LeadingAnchor.ConstraintEqualTo(View.LeadingAnchor).Active = true;
            animView.BottomAnchor.ConstraintEqualTo(View.BottomAnchor).Active = true;
            animView.Play();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
