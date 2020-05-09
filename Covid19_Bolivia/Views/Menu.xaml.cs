using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid19_Bolivia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var mainPage = (Application.Current.MainPage as NavigationPage).CurrentPage;

            if ((mainPage as MasterDetailPage).IsPresented)
            {
                (mainPage as MasterDetailPage).IsPresented = false;
            }
            else
            {
                (mainPage as MasterDetailPage).IsPresented = true;
            }
        }
        private void BotonIniSec(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuIniSesion());
        }
        private void BotonNotificacion(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuNotificacion());
        }
    }
}