﻿namespace FFImageLoadingDemo.iOS
{
    using FFImageLoading.Forms.Platform;
    using FFImageLoading.Svg.Forms;
    using Foundation;
    using UIKit;
    using Xamarin.Forms;

    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Forms.Init();
            CachedImageRenderer.Init();
            var ignore = typeof(SvgCachedImage);
            CachedImageRenderer.Init();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
