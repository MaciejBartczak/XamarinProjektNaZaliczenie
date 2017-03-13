using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace XamarinProjektNaZaliczenie
{
    [Activity(Label = "XamarinProjektNaZaliczenie", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button bSMS;
        Button bPhone;
        Button bWebView;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            bSMS = FindViewById<Button>(Resource.Id.MainSMSButton);
            bPhone = FindViewById<Button>(Resource.Id.MainPhoneButton);
            bWebView = FindViewById<Button>(Resource.Id.MainWebViewerButton);

            bSMS.Click += delegate
            {
                var intent = new Intent(this, typeof(SMSActivity));
                StartActivity(intent);
            };

            bPhone.Click += delegate
            {
                var intent = new Intent(this, typeof(PhoneActivity));
                StartActivity(intent);
            };

            bWebView.Click += delegate
            {
                var intent = new Intent(this, typeof(WebViewerActivity));
                StartActivity(intent);
            };
        }

        
    }
}

