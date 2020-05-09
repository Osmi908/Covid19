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
        private object item;

        public MostrarDatos()
        {
            
        }

        public MostrarDatos(object item)
        {
            InitializeComponent();
            this.item = item;
            Datos dato = (Datos)item;
            Map map = new Map();

            Position position = new Position(dato.Latitud, dato.Longitud);
            Pin pin = new Pin
            {
                Label = "Microsoft San Francisco",
                Address = "1355 Market St, San Francisco CA",
                Type = PinType.Place,
                Position = position
            };
            map.Pins.Add(pin);

            Circle circle = new Circle
            {
                Center = position,
                Radius = new Distance(250),
                StrokeColor = Color.FromHex("#88FF0000"),
                StrokeWidth = 8,
                FillColor = Color.FromHex("#88FFC0CB")
            };
            map.MapElements.Add(circle);

            Title = "Circle demo";
            Content = map;
            Polygon polygon = new Polygon
            {
                StrokeWidth = 4,
                StrokeColor = Color.FromHex("#1BA1E2"),
                FillColor = Color.FromHex("#881BA1E2"),
                Geopath =
    {
        position,
new Position(-16.489689,-68.1192936),
new Position(-17.4139766, -66.1653224),
new Position(-21.5177889, -64.7295667),


    }
            };

            // add the polygon to the map's MapElements collection
            map.MapElements.Add(polygon);
            map.MoveToRegion(
               MapSpan.FromCenterAndRadius(
                   position, Distance.FromKilometers(200)));
        }
    }
}