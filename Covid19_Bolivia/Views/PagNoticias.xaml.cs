using Covid19_Bolivia.Helper;
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
    public partial class PagNoticias : ContentPage
    {
        readonly FireBaseHelper firebaseHelper = new FireBaseHelper();
        public PagNoticias()
        {

            InitializeComponent();
            _ = FetchAllPersons();
        }
        private async Task FetchAllPersons()
        {
            var allPersons = await firebaseHelper.GetAllPersons();

            for (int i = 0; i < allPersons.Count; i++)
            {
                allPersons[i].cambiarImg();
            }
            LstPersons.ItemsSource = allPersons;
        }
    }
}