using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Webkit;

namespace XamarinProjektNaZaliczenie
{
    [Activity(Label = "WebViewerActivity")]
    public class WebViewerActivity : Activity
    {
        Button bExit;
        Button bSend;
        WebView wWebView;
        EditText eWebViewerUrl;
         
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.WebViewer);

            bExit = FindViewById<Button>(Resource.Id.WebViewerExit);
            bSend = FindViewById<Button>(Resource.Id.WebViewerSearch);
            wWebView = FindViewById<WebView>(Resource.Id.webViewContent);
            eWebViewerUrl = FindViewById<EditText>(Resource.Id.WebViewerUrl);

            wWebView.Settings.JavaScriptEnabled = true;
            wWebView.LoadUrl("http://www.google.com");
            wWebView.SetWebViewClient(new CustomWebViewClient());

            eWebViewerUrl.SetHintTextColor(Android.Graphics.Color.White);


            bExit.Click += delegate
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };

            bSend.Click += delegate
            {
                wWebView.LoadUrl(eWebViewerUrl.Text.ToString());
                wWebView.SetWebViewClient(new CustomWebViewClient());
                
            };

        }
    }

    public class CustomWebViewClient : WebViewClient
    {
        public override bool ShouldOverrideUrlLoading(WebView view, string url)
        {
            view.LoadUrl(url);
            return true;
        }
    }
}