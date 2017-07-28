using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Syncfusion.SfCarousel.XForms.iOS;
using UIKit;

namespace strc.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

#pragma warning disable RECS0026 // Possible unassigned object created by 'new'
			new SfCarouselRenderer();
#pragma warning restore RECS0026 // Possible unassigned object created by 'new'

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
