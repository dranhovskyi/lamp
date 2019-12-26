using Lamp.Core;
using MvvmCross.Platforms.Ios.Core;

namespace Lamp.iOS
{
    public class Setup : MvxIosSetup<App>
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