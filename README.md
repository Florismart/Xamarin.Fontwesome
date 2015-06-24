Fontwesome
=============

Fontysfaction is an Open Source Xamarin iOS library that allows developers to easily create applications with custom fonts. Feel free to use it all you want in your Android apps provided that you cite this project and include the license in your app.


![Screenshot](https://raw.githubusercontent.com/Florismart/Xamarin.Fontwesome/master/screen-app.png)


Setup
-----
__1.__ In Xamarin, import the library as an Android library project. Now you can build it and export as DLL.

__2.__ Then, add Fontwesome dll as a dependency to your existing project.

__3.__ Add now your embedded font to .plist file ( and remember to set "BUILD ACTION as BundleResource" and "Copy to output directory as Always Copy" for single font)!

__4.__ At Last quick setup your application class and you are good to go!

```C#
[Register ("AppDelegate")]
public partial class AppDelegate : UIApplicationDelegate
{

    public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			InitFonts ();
			//...
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
		
		
}
```

Configuration
-----
To use your fonts in app just init FontwesomeLoader..
```C#
    FontwesomeLoader.GetInstance ().Init (new Dictiaonary<string, string>());
```
with your fonts mapping!

Usage
-----
Configurations ended! Now open your storyboard or simple xibs and use our 

- FontwesomeButton as UIButton
- FontwesomeLabel as UILabel
- FontwesomeTextField as UITextField

...and set User Runtimes


![Screenshot](https://raw.githubusercontent.com/Florismart/Xamarin.Fontwesome/master/runtime_attrbutes.png)


