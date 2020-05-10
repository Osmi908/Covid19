using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps;

namespace Covid19_Bolivia.Models
{
    class Departamento
    {
        public string Nombre { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public List<Position> Poligon { get; set; }
    }
}
