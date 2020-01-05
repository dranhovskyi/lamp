using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;

namespace Lamp.iOS.Views.Abstract
{
    public class BaseTableViewCell : MvxTableViewCell
    {
        protected BaseTableViewCell()
        {
        }

        protected BaseTableViewCell(IntPtr handle) : base(handle)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();

            InitViewCell();
            this.DelayBind(Bind);
        }

        protected virtual void InitViewCell()
        {
            this.SelectionStyle = UIKit.UITableViewCellSelectionStyle.None;
        }

        protected virtual void Bind()
        {
        }
    }
}
