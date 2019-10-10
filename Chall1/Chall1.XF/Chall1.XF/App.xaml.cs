using Syncfusion.Licensing;
using Xamarin.Forms;

namespace Chall1.XF
{
    public partial class App : Application
    {
        public App()
        {
            SyncfusionLicenseProvider.RegisterLicense("MTQ3NzYxQDMxMzcyZTMyMmUzMEJJaW02UEVxS3dDQXg4Q2tEM0lYeGNrd2NpVm1ZODNzY21LN2h0bkY5OUk9");

            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
