using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Bolivia.Models
{
    class DatosLatitud
    {

        public class Rootobject
        {
            public string type { get; set; }
            public Crs crs { get; set; }
            public Feature[] features { get; set; }
        }

        public class Crs
        {
            public string type { get; set; }
            public Properties properties { get; set; }
        }

        public class Properties
        {
            public string name { get; set; }
        }

        public class Feature
        {
            public string type { get; set; }
            public Properties1 properties { get; set; }
            public Geometry geometry { get; set; }
        }

        public class Properties1
        {
            public int id { get; set; }
            public int objectid { get; set; }
            public string cod_ut { get; set; }
            public string departamen { get; set; }
            public string provincia { get; set; }
            public string municipio { get; set; }
            public string capital { get; set; }
        }

        public class Geometry
        {
            public string type { get; set; }
            public float[][][][] coordinates { get; set; }
        }

    }
}
