using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;

namespace Lamp.iOS.Views.Abstract
{
    public class BaseCollectionViewCell : MvxCollectionViewCell
    {
        protected BaseCollectionViewCell()
        {
        }

        protected BaseCollectionViewCell(IntPtr handle) : base(handle)
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
        }

        protected virtual void Bind()
        {
        }
    }
}
