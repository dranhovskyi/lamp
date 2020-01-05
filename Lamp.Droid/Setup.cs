using Lamp.Core;
using MvvmCross.Platforms.Android.Core;

namespace Lamp.Droid
{
    public class Setup : MvxAndroidSetup<App>
    {
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();
            //Register services
            //Mvx.IoCProvider.RegisterType<IMvxJsonConverter, MvxJsonConverter>();
        }

        protected override void InitializeLastChance()
        {
            base.InitializeLastChance();
        }
    }
}