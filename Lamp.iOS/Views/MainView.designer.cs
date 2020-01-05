// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Lamp.iOS.Views
{
    [Register ("MainView")]
    partial class MainView
    {
        [Outlet]
        UIKit.UIButton DynamicScrollViewButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Generosity { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider GenerositySlider { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel SubTotal { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField SubTotalTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton TableViewButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TipLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Generosity != null) {
                Generosity.Dispose ();
                Generosity = null;
            }

            if (GenerositySlider != null) {
                GenerositySlider.Dispose ();
                GenerositySlider = null;
            }

            if (SubTotal != null) {
                SubTotal.Dispose ();
                SubTotal = null;
            }

            if (SubTotalTextField != null) {
                SubTotalTextField.Dispose ();
                SubTotalTextField = null;
            }

            if (TableViewButton != null) {
                TableViewButton.Dispose ();
                TableViewButton = null;
            }

            if (TipLabel != null) {
                TipLabel.Dispose ();
                TipLabel = null;
            }
        }
    }
}