using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Florismart.Fontwesome.iOS.Core;

namespace Florismart.Fontwesome.iOS.Sample
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		public static UIStoryboard Storyboard = UIStoryboard.FromName ("MainStoryboard", null);
		public static UIViewController initialViewController;

		public override UIWindow Window {
			get;
			set;
		}

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			InitFonts ();
			Window = new UIWindow (UIScreen.MainScreen.Bounds);

			initialViewController = Storyboard.InstantiateInitialViewController () as UIViewController;

			Window.RootViewController = initialViewController;
			Window.MakeKeyAndVisible ();

			return true;
		}

		private void InitFonts ()
		{
			var fontMap = new Dictionary<string, string> ();
			fontMap.Add ("medium", "Roboto-Medium");
			fontMap.Add ("bold", "Roboto-Bold");
			fontMap.Add ("thin", "Roboto-Thin");
			fontMap.Add ("regular", "Roboto-Regular");
			FontwesomeLoader.GetInstance ().Init (fontMap);
		}
		
		// This method is invoked when the application is about to move from active to inactive state.
		// OpenGL applications should use this method to pause.
		public override void OnResignActivation (UIApplication application)
		{
		}
		
		// This method should be used to release shared resources and it should store the application state.
		// If your application supports background exection this method is called instead of WillTerminate
		// when the user quits.
		public override void DidEnterBackground (UIApplication application)
		{
		}
		
		// This method is called as part of the transiton from background to active state.
		public override void WillEnterForeground (UIApplication application)
		{
		}
		
		// This method is called when the application is about to terminate. Save data, if needed.
		public override void WillTerminate (UIApplication application)
		{
		}
	}
}

