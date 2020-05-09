using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Covid19_Bolivia.Views;

namespace Covid19_Bolivia
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            NavigationPage Nav = new NavigationPage(new MainPage());
            MainPage = Nav;
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
