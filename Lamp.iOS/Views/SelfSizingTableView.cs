using System;
using Lamp.Core.ViewModels;
using Lamp.iOS.Views.Abstract;
using Lamp.iOS.Views.Cells;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace Lamp.iOS.Views
{
    [MvxFromStoryboard(nameof(SelfSizingTableView))]
    public partial class SelfSizingTableView : BaseView<SelfSizingTableViewModel>
    {
        MvxTableViewSource tableViewSource;

        public SelfSizingTableView(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            tableViewSource = new MvxSimpleTableViewSource(TableView, nameof(SelfSizingViewCell), SelfSizingViewCell.Key);
            TableView.Source = tableViewSource;
            TableView.RowHeight = UITableView.AutomaticDimension;
            TableView.EstimatedRowHeight = 44.0f;

            DoBind();
        }

        private void DoBind()
        {
            var set = this.CreateBindingSet<SelfSizingTableView, SelfSizingTableViewModel>();
            set.Bind(tableViewSource).To(vm => vm.Titles);
            set.Apply();
        }
    }
}

