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

namespace XamarinProjektNaZaliczenie
{
    [Activity(Label = "SMS")]
    public class SMSActivity : Activity
    {
        Button bExit;
        Button bSend;
        EditText eReceiver;
        EditText eContent;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.SMS);

            bExit = FindViewById<Button>(Resource.Id.SMSExitButton);
            bSend = FindViewById<Button>(Resource.Id.SMSSendButton);
            eReceiver = FindViewById<EditText>(Resource.Id.SMSReceiverInput);
            eContent = FindViewById<EditText>(Resource.Id.SMSContentInput);


            bExit.Click += delegate
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };

            bSend.Click += delegate
            {
                Intent intent = new Intent(Intent.ActionSendto, Android.Net.Uri.Parse("smsto:" + eReceiver.Text.ToString()));
                intent.PutExtra("sms_body", eContent.Text.ToString());
                StartActivity(intent);
            };

            
        }
    }
}