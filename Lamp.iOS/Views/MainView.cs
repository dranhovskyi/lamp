using System;
using Lamp.Core.ViewModels;
using Lamp.iOS.Views.Abstract;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace Lamp.iOS.Views
{
    [MvxFromStoryboard(nameof(MainView))]
    public partial class MainView : BaseView<MainViewModel>
    {
        public MainView(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            DoBind();
        }

        private void DoBind()
        {
            var set = this.CreateBindingSet<MainView, MainViewModel>();
            set.Bind(TipLabel).To(vm => vm.Tip);
            set.Bind(SubTotalTextField).To(vm => vm.SubTotal);
            set.Bind(GenerositySlider).To(vm => vm.Generosity);
            set.Bind(TableViewButton).To(vm => vm.NavigateToTableViewCommand);
            set.Apply();

            View.AddGestureRecognizer(new UITapGestureRecognizer(() =>
            {
                this.SubTotalTextField.ResignFirstResponder();
            }));
        }
    }
}

