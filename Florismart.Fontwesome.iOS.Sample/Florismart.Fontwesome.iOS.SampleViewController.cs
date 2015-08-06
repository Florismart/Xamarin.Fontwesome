using System;
using CoreGraphics;

using Foundation;
using UIKit;
using System.Linq;

namespace Florismart.Fontwesome.iOS.Sample
{
	public partial class Florismart_Fontwesome_iOS_SampleViewController : UIViewController
	{
		public Florismart_Fontwesome_iOS_SampleViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			MyFontwesomeButton.Fontwesome = "regular";
		}

	}
}

