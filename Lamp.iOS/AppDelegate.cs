using System;
using Foundation;
using Lamp.Core;
using MvvmCross.Platforms.Ios.Core;
using UIKit;

namespace Lamp.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
        public override void OnActivated(UIApplication application)
        {
            Console.WriteLine("OnActivated called, App is active.");
        }

        public override void WillEnterForeground(UIApplication application)
        {
            Console.WriteLine("App will enter foreground");
        }

        public override void OnResignActivation(UIApplication application)
        {
            Console.WriteLine("OnResignActivation called, App moving to inactive state.");
        }

        public override void DidEnterBackground(UIApplication application)
        {
            Console.WriteLine("App entering background state.");
        }

        // not guaranteed that this will run
        public override void WillTerminate(UIApplication application)
        {
            Console.WriteLine("App is terminating.");
        }
    }
}
