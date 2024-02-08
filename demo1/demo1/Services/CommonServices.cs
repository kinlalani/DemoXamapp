using Xamarin.Forms;

namespace SMS_DetectApp.Services
{
    public static class CommonServices
    {
        public static void ListenToSmsRetriever()
        {
            DependencyService.Get<IListenToSmsRetriever>()?.ListenToSmsRetriever();
        }
    }
    public interface IListenToSmsRetriever
    {
        void ListenToSmsRetriever();
    }
    public interface IForegroundService
    {
        void StartMyForegroundService();
        //void StopMyForegroundService();

        bool IsForeGroundServiceRunning();
    }
}