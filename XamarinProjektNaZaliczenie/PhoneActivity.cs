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
using Android.Net;

namespace XamarinProjektNaZaliczenie
{
    [Activity(Label = "Phone")]
    public class PhoneActivity : Activity
    {
        Button bExit;
        Button bCall;
        EditText ePhoneNumber;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            

            SetContentView(Resource.Layout.Phone);

            bExit = FindViewById<Button>(Resource.Id.PhoneExitButton);
            bCall = FindViewById<Button>(Resource.Id.PhoneCallButton);
            ePhoneNumber = FindViewById<EditText>(Resource.Id.PhoneNumber);

            bExit.Click += delegate
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };

            bCall.Click += delegate
            {
                var intent = new Intent(Intent.ActionDial);
                intent.SetData(Android.Net.Uri.Parse("tel:" + ePhoneNumber.Text.ToString()));
                StartActivity(intent);
            };
        }
    }
}