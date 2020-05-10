using Covid19_Bolivia.Helper;
using Covid19_Bolivia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Covid19_Bolivia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MostrarDatos : ContentPage
    {
        readonly FireBaseHelper firebaseHelper = new FireBaseHelper();
        private object item;
        public Circle circulo { get; set; }
        public MostrarDatos()
        {
            
        }

        public MostrarDatos(object item)
        {
            circulo = new Circle();
            InitializeComponent();
            
            this.item = item;
            Departamento dato = (Departamento)item;
            Map map = new Map();
            Position position = new Position(dato.Latitud, dato.Longitud);



            Title = "Circle demo";
            Content = map;
            Polygon polygon = new Polygon
            {
                StrokeWidth = 4,
                StrokeColor = Color.FromHex("#300707"),
                FillColor = Color.Transparent,

                    
                
            };

            for (int i = 0; i < dato.Poligon.Count; i++)
            {
                polygon.Geopath.Add(dato.Poligon[i]);
            };
             var allPersons = firebaseHelper.GetDateMaps("");

            for (int i = 0; i < allPersons.Count; i++)
            {
                Pin pin = new Pin
                {
                    Label = allPersons[i].Municipio,
                    Address = allPersons[i].Indice+" "+allPersons[i].Sup,
                    Type = PinType.Generic,
                    Position = new Position(allPersons[i].Latitud, allPersons[i].Longitud),
                };
                map.Pins.Add(pin);
                circulo = new Circle
                {
                    Center = new Position(allPersons[i].Latitud,allPersons[i].Longitud),
                    Radius = new Distance((allPersons[i].Sup*10000)),
                    StrokeColor = cambiarColor(allPersons[i].grado),
                    StrokeWidth = 8,
                    FillColor = cambiarColor(allPersons[i].grado)
                };
                map.MapElements.Add(circulo);
            }
            // add the polygon to the map's MapElements collection
            map.MapElements.Add(polygon);
            map.MoveToRegion(
               MapSpan.FromCenterAndRadius(
                   position, Distance.FromKilometers(200)));
        }
        public Color cambiarColor(int a)
        {
            Color color = new Color();
            if (a==2)
            {
                color = Color.Red;
            }
            else
            {
                if (a==1)
                {
                    color = Color.Yellow;
                }
                else
                {
                    color = Color.Green;
                }
            }
            return color;
        }
        private async Task FetchAllPersons()
        {
           
        }
    }
}