// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Florismart.Fontwesome.iOS.Sample
{
	[Register ("Florismart_Fontwesome_iOS_SampleViewController")]
	partial class Florismart_Fontwesome_iOS_SampleViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Florismart.Fontwesome.iOS.View.FontwesomeButton MyFontwesomeButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Florismart.Fontwesome.iOS.View.FontwesomeLabel MyFontwesomeLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Florismart.Fontwesome.iOS.View.FontwesomeTextField MyFontwesomeTextField { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (MyFontwesomeButton != null) {
				MyFontwesomeButton.Dispose ();
				MyFontwesomeButton = null;
			}
			if (MyFontwesomeLabel != null) {
				MyFontwesomeLabel.Dispose ();
				MyFontwesomeLabel = null;
			}
			if (MyFontwesomeTextField != null) {
				MyFontwesomeTextField.Dispose ();
				MyFontwesomeTextField = null;
			}
		}
	}
}
