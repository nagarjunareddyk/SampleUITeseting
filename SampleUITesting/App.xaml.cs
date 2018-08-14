using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace SampleUITesting
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SampleUITestingPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("ios=4fe2f8e0-f7eb-482a-b89b-38d79224dc6c;" +
                  "uwp={Your UWP App secret here};" +
                            "android=b9d82c73-0b24-4355-a4a2-de6f1ee2ae7c;",
                            typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
