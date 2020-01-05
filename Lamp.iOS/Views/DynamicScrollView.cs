using System;
using Lamp.Core.ViewModels;
using Lamp.iOS.Views.Abstract;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;

namespace Lamp.iOS.Views
{
    [MvxFromStoryboard(nameof(DynamicScrollView))]
    public partial class DynamicScrollView : BaseView<DynamicScrollViewModel>
    {
        public DynamicScrollView(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            DoBind();
        }

        private void DoBind()
        {
            var set = this.CreateBindingSet<DynamicScrollView, DynamicScrollViewModel>();
            set.Apply();
        }
    }
}

