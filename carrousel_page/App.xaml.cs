using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace carrousel_page
{
    public partial class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new temperament());
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
