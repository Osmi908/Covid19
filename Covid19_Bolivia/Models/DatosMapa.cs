using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Bolivia.Models
{

    public class DatosMapa
    {
        public Dato[] Datos { get; set; }
    }

    public class Dato
    {
        public string Departamento { get; set; }
        public int id_Dato { get; set; }
        public string Municipio { get; set; }
        public int datoC { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }
        public float Sup { get; set; }
        public int grado { get; set; }
        public float Indice { get; set; }
        public int datosC { get; set; }
    }

}
