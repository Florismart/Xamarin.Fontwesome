using System;
using UIKit;
using Foundation;
using System.Collections.Generic;
using Florismart.Fontwesome.iOS.Core;

namespace Florismart.Fontwesome.iOS.View
{
	[Register ("FontwesomeButton")]
	public partial class FontwesomeButton: UIButton
	{
		[Export ("fontwesome")]
		private string _fontwesome { get; set; }

		public string Fontwesome {
			get { 
				return _fontwesome;
			}
			set {
				if (CheckFont ()) {
					_fontwesome = value;
					SetFont ();
				}
			}
		}

		public FontwesomeButton (IntPtr handle) : base (handle)
		{
		}

		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();
			if (CheckFont ())
				SetFont ();
		}

		private bool CheckFont ()
		{
			return !string.IsNullOrEmpty (_fontwesome) && FontwesomeLoader.GetInstance ().FontMap.ContainsKey (_fontwesome);
		}

		private void SetFont ()
		{
//			Console.WriteLine (string.Format ("Setting font: {0} as: {1}", _fontwesome, FontwesomeLoader.GetInstance ().FontMap [_fontwesome]));
			Font = UIFont.FromName (FontwesomeLoader.GetInstance ().FontMap [_fontwesome], Font.PointSize);
		}
	}
}

