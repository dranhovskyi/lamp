using Lamp.Core;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.ViewModels;

namespace Lamp.Droid
{
    public class Setup : MvxAndroidSetup<App>
    {
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();

            // Mvx.IoCProvider.RegisterType<IMvxJsonConverter, MvxJsonConverter>();
        }

        protected override void InitializeLastChance()
        {
            base.InitializeLastChance();
        }
    }
}