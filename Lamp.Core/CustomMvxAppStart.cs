using System;
using System.Threading.Tasks;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Lamp.Core
{
    public class CustomMvxAppStart<TViewModel> : MvxAppStart<TViewModel>
     where TViewModel : IMvxViewModel
    {
        public CustomMvxAppStart(IMvxApplication application, IMvxNavigationService navigationService) : base(application, navigationService)
        {
        }

        protected override Task NavigateToFirstViewModel(object hint = null)
        {
            return NavigationService.Navigate<TViewModel>();
        }
    }
}
