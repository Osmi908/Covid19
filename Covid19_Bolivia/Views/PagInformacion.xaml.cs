using Covid19_Bolivia.ViewModels;
using Covid19_Bolivia.Views;
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
    public partial class PagInformacion : ContentPage
    {

        public PagInformacion()
        {
            InitializeComponent();
            BindingContext = new DatosViewModel();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new MostrarDatos(e.Item));
        }
    }
}