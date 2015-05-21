using System;
using System.Collections.Generic;

namespace Florismart.Fontwesome.iOS.Core
{
	public class FontwesomeLoader
	{
		private static FontwesomeLoader instance = null;

		public Dictionary<string, string> _fontMap;

		public Dictionary<string, string> FontMap {
			get {
				return _fontMap;
			}
		}

		private FontwesomeLoader ()
		{
			_fontMap = new Dictionary<string, string> ();
		}

		public static FontwesomeLoader GetInstance ()
		{
			if (instance == null)
				instance = new FontwesomeLoader ();
			return instance;
		}

		public FontwesomeLoader Init (Dictionary<string, string> fontMap)
		{
			_fontMap = fontMap;
			return this;
		}
	}
}

