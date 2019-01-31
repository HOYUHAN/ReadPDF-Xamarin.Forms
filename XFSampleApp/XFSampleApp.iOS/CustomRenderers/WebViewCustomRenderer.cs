using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

using Foundation;
using UIKit;
using WebKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using XFSampleApp.iOS.CustomRenderers;

[assembly: ExportRenderer(typeof(WebView), typeof(WebViewCustomRenderer))]
namespace XFSampleApp.iOS.CustomRenderers
{
    public class WebViewCustomRenderer : WebViewRenderer
    {

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (NativeView != null && e.NewElement != null)
            {
                if (!(NativeView is UIWebView webViewControl))
                    return;

                webViewControl.ScalesPageToFit = true;
                webViewControl.MultipleTouchEnabled = true;

            }

        }

    }
}