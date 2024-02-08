using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms.PlatformConfiguration;

namespace demo1.Droid
{
    [BroadcastReceiver(Exported = V, Enabled =true)]
    [IntentFilter(new[] {"android.provider.Telephony.SMS_RECEIVED" },Priority =(int)IntentFilterPriority.HighPriority)]
    public class MyReceiver : BroadcastReceiver
    {
        private const bool V = true;

        public override void OnReceive(Context context, Intent intent)
        {
            Toast.MakeText(context, "Received intent!", ToastLength.Short).Show();
        }
    }
}