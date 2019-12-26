using System;
using Android.App;
using Android.Runtime;
using MvvmCross.Platforms.Android.Views;
using Lamp.Core;

namespace Lamp.Droid
{
    [Application]
    public class MainApplication : MvxAndroidApplication<Setup, App>
    {
        public MainApplication()
        {
        }

        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }
    }
}