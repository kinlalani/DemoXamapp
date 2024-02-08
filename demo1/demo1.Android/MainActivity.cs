using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Android.Nfc;
using Android.Util;
using AndroidX.Core.App;
using Google.Android.Material.Snackbar;
using AndroidX.Core.Content;
using Android;
using Android.Views;
using Android.Content;
using demo1.Droid.Services;
using demo1.Droid.Helper;
using static Android.Gms.Common.Apis.Api;
using Android.Gms.Tasks;
using Java.Lang;
using Exception = Java.Lang.Exception;
using Object = Java.Lang.Object;
using Android.Gms.Auth.Api.Phone;

namespace demo1.Droid
{
    [Activity(Label = "demo1", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        static readonly int REQUEST_SENDSMS = 0;
      
        View layout;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            layout = FindViewById(Resource.Id.staticLayout);
            if (ContextCompat.CheckSelfPermission(this, Manifest.Permission.SendSms) == (int)Permission.Granted &&
                ContextCompat.CheckSelfPermission(this, Manifest.Permission.ReceiveSms) == (int)Permission.Granted &&
                ContextCompat.CheckSelfPermission(this, Manifest.Permission.ReadSms) == (int)Permission.Granted)
            {
                // We have permission, go ahead and use the camera.

            }
            else
            {
                if (ActivityCompat.ShouldShowRequestPermissionRationale(this, Manifest.Permission.SendSms))
                {
                    Log.Info("MainActivity", "Displaying SMS permission rationale to provide additional context.");
                    Snackbar.Make(layout, "SMS permission is needed for this app running.",
                        Snackbar.LengthIndefinite).SetAction("OK", new Action<View>(delegate (View obj) {
                            ActivityCompat.RequestPermissions(this, new System.String[] { Manifest.Permission.SendSms,Manifest.Permission.ReadSms,Manifest.Permission.ReceiveSms }
                            , REQUEST_SENDSMS);
                           
                        })).Show();
                }
                else
                {
                    ActivityCompat.RequestPermissions(this, new System.String[] { Manifest.Permission.SendSms }, REQUEST_SENDSMS);
                }
            }
           
            LoadApplication(new App());
            string Value = AppHashKeyHelper.GetAppHashKey(this);

           
            //task.AddOnSuccessListener(new SuccessListener());
            //task.AddOnFailureListener(new FailureListener());


        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
        
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        protected override void OnDestroy()
        {
            base.OnDestroy();
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