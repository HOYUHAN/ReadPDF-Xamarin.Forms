
using Android.Content;
using System.Net;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFSampleApp.Droid.CustomRenderers;

[assembly: ExportRenderer(typeof(WebView), typeof(WebViewCustomRenderer))]
namespace XFSampleApp.Droid.CustomRenderers
{
    public class WebViewCustomRenderer : WebViewRenderer
    {
        public WebViewCustomRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                Control.SetWebViewClient(new Android.Webkit.WebViewClient());

                Control.Settings.JavaScriptEnabled = true;

                Control.Settings.AllowUniversalAccessFromFileURLs = true;

            }

        }
    }
}