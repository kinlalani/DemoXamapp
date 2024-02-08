using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Telephony;
using demo1.Droid.Services;
using demo1.Services;
using System;
using System.Linq;
using Java.Lang;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;
using Object = Java.Lang.Object;
using StringBuilder = Java.Lang.StringBuilder;
using Android.Media;
using Android.Gms.Auth.Api.Phone;
using Android.Gms.Tasks;
using Application = Android.App.Application;
using Exception = Java.Lang.Exception;
using demo1.Droid.Helper;

[assembly: Dependency(typeof(AudioService))]
namespace demo1.Droid.Services
{
    public class AudioService : IAudioService
    {

        //static MediaPlayer mediaPlayer;
        public void PlaySoundThroughSpeaker()
        {
           
            SmsManager.Default.SendTextMessage("9429013122", null,"<#>67777 - test fHhuebWm+Hj", null, null);

            // Intent i = new Intent("MY_SPECIFIC_ACTION");
            // i.PutExtra("key", "some value from intent");
            // // SendBroadcast(i);  
            //// SendOrderedBroadcast(i, null);
            // Android.App.Application.Context.SendBroadcast(i);
            // Android.App.Application.Context.SendOrderedBroadcast(i,null);
            //

            //var message = new SmsMessage("Hello I am from demo1","7016416565");
            // Sms.ComposeAsync(message);

            //var mediaPlayer = MediaPlayer.Create(Application.Context, (Resource.Raw.sample_sound));

            //mediaPlayer.Start();
        }

        public void StopMediaPlayer()
        {
            //var mediaPlayer = MediaPlayer.Create(Android.App.Application.Context, (Resource.Raw.sample_sound));

            //mediaPlayer.Stop();

            if (Player.player.IsPlaying)
            {
                Player.player.Stop();
                Player.player = null;
            }
        }

        public void StartSMSRetriver()
        {

            //SmsRetrieverClient client = SmsRetriever.GetClient(Application.Context);
            //var task = client.StartSmsRetriever();
            int cnt = 1;
            int maxcount = 5;
            Device.StartTimer(TimeSpan.FromSeconds(2), () =>
            {
                SmsRetrieverClient client = SmsRetriever.GetClient(Application.Context);
                var task = client.StartSmsRetriever();
                // called every 1 second
                // do stuff here
                cnt++;
                if (cnt == maxcount)
                    return false;
                else
                    return true; // return true to repeat counting, false to stop timer
            });
        }

        private class SuccessListener : Object, IOnSuccessListener
        {
            public void OnSuccess(Object result)
            {
            }
        }
        private class FailureListener : Object, IOnFailureListener
        {
            public void OnFailure(Exception e)
            {
            }
        }
    }
}
