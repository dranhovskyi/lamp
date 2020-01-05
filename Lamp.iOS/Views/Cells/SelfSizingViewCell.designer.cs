// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Lamp.iOS.Views.Cells
{
	[Register ("SelfSizingViewCell")]
	partial class SelfSizingViewCell
	{
		[Outlet]
		UIKit.UILabel DescriptionLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UILabel TitleLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (TitleLabel != null) {
				TitleLabel.Dispose ();
				TitleLabel = null;
			}

			if (DescriptionLabel != null) {
				DescriptionLabel.Dispose ();
				DescriptionLabel = null;
			}
		}
	}
}
