using demo1.Services;
using SMS_DetectApp.Services;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace demo1.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();

            if (DependencyService.Resolve<IForegroundService>().IsForeGroundServiceRunning())
            {
                App.Current.MainPage.DisplayAlert("Opps", "Foreground Service Is Already Running", "OK");
            }
            else
            {
                DependencyService.Resolve<IForegroundService>().StartMyForegroundService();
            }
            DependencyService.Get<IAudioService>().StartSMSRetriver();

            this.Subscribe<string>(Events.SmsRecieved, code =>
            {
                smSEntry.Text = code;
            });
        }

        private void btnDanger_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudioService>().PlaySoundThroughSpeaker();
        }

        private void btStop_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudioService>().StopMediaPlayer();
        }
    }
}