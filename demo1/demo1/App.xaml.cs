using demo1.Services;
using demo1.Views;
using SMS_DetectApp.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace demo1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();

            if (DependencyService.Resolve<IForegroundService>().IsForeGroundServiceRunning())
            {
                App.Current.MainPage.DisplayAlert("Opps", "Foreground Service Is Already Running", "OK");
            }
            else
            {
                DependencyService.Resolve<IForegroundService>().StartMyForegroundService();
            }   
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
