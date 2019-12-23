using Android.App;
using Android.OS;
using Android.Widget;
using Lamp.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Views;

namespace Lamp.Droid.Views
{
    [Activity(Label = "Main View", MainLauncher = true)]
    public class MainView : MvxActivity<MainViewModel>
    {
        private EditText _subTotalTextField;
        private SeekBar _generositySlider;
        private TextView _tipLabel;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);

            DoBind();
        }

        private void DoBind()
        {
            _subTotalTextField = FindViewById<EditText>(Resource.Id.subTotal);
            _generositySlider = FindViewById<SeekBar>(Resource.Id.generosity);
            _tipLabel = FindViewById<TextView>(Resource.Id.tip);

            var set = this.CreateBindingSet<MainView, MainViewModel>();
            set.Bind(_subTotalTextField).For(v => v.Text).To(vm => vm.SubTotal);
            set.Bind(_generositySlider).For(v => v.Progress).To(vm => vm.Generosity);
            set.Bind(_tipLabel).For(v => v.Text).To(vm => vm.Tip);

            set.Apply();
        }
    }
}