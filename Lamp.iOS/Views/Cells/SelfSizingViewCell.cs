using System;
using Foundation;
using Lamp.Core.ViewModels.Cells;
using Lamp.iOS.Views.Abstract;
using MvvmCross.Binding.BindingContext;
using UIKit;

namespace Lamp.iOS.Views.Cells
{
    public partial class SelfSizingViewCell : BaseTableViewCell
    {
        public static readonly NSString Key = new NSString(nameof(SelfSizingViewCell));
        public static readonly UINib Nib = UINib.FromName(nameof(SelfSizingViewCell), NSBundle.MainBundle);

        protected SelfSizingViewCell(IntPtr handle) : base(handle)
        {

        }

        protected override void Bind()
        {
            var bindingSet = this.CreateBindingSet<SelfSizingViewCell, SelfSizingCellViewModel>();

            bindingSet.Bind(TitleLabel).To(vm => vm.Title);
            bindingSet.Bind(DescriptionLabel).To(vm => vm.Description);

            bindingSet.Apply();
        }
    }
}
