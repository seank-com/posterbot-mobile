﻿using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;
using Posterbot.Core;
using UIKit;

namespace Posterbot.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxFormsApplicationDelegate<MvxFormsIosSetup<App, FormsApp>, App, FormsApp>
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Xamarin.Forms.Forms.Init();
            Syncfusion.SfBusyIndicator.XForms.iOS.SfBusyIndicatorRenderer.Init();
            Syncfusion.ListView.XForms.iOS.SfListViewRenderer.Init();

            return base.FinishedLaunching(app, options);
        }
    }
}
