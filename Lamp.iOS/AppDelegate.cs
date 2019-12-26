using Foundation;
using Lamp.Core;
using MvvmCross.Platforms.Ios.Core;
using UIKit;

namespace Lamp.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
    }
}
