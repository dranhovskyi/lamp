using Lamp.Core.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace Lamp.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();
        }
    }
}
