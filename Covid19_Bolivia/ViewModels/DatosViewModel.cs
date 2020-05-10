using Covid19_Bolivia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Covid19_Bolivia.ViewModels
{
    class DatosViewModel:INotifyPropertyChanged
    {
        public List<Departamento> ciudad { get; set; }
        public Departamento datos { get; set; }
        public DatosViewModel()
        {
             
            
            ciudad = new List<Departamento>();
            datos = new Departamento() { 
                Nombre = "SANTA CRUZ",
                Latitud=-17.8145819,
                Longitud=-63.1560853,Poligon=new List<Position>(){ 
                    new Position(-16.255766, -60.177034),
                    new Position(-16.266313, -58.336825),
                    new Position(-18.228262, -57.518343),
                    new Position(-20.096129, -58.133578),
                    new Position(-19.310061, -59.100374),
                    new Position(-19.827646, -61.824984),
                    new Position(-20.433092, -62.236070),
                    new Position(-20.433092, -63.686265),
                    new Position(-19.026710, -63.752183),
                    new Position(-17.859465, -64.806870),
                    new Position(-17.377802, -64.257554),
                    new Position(-15.840777, -64.718980),
                    new Position(-15.840777, -64.718980),
                    new Position(-14.674902, -63.993882),
                    new Position(-13.502781, -61.093492),
                    new Position(-13.673642, -60.697984),
                    new Position(-15.082732, -60.260010),
                    new Position(-15.093339, -60.578613),
                    new Position(-15.485445, -60.238037)


                } };
            ciudad.Add(datos);
            datos = new Departamento()
            {
                Nombre = "LA PAZ",
                Latitud = -14.9482683,
                Longitud = -68.1886797,
                Poligon = new List<Position>(){
                    new Position(-11.844000, -68.004659),
                    new Position(-12.536635, -66.933492),
                    new Position(-12.826029, -66.966451),
                    new Position(-13.430530, -67.400411),
                    new Position(-13.622799, -67.383931),
                    new Position(-13.782903, -67.510274),
                    new Position(-14.597705, -67.537740),
                    new Position(-14.815546, -67.400411),
                    new Position(-15.042452, -67.268575),
                    new Position(-15.339320, -67.087300),
                    new Position(-15.386992, -67.117513),
                    new Position(-15.773257, -66.809896),
                    new Position(-16.087548, -66.919759),
                    new Position(-16.746195, -66.741231),
                    new Position(-16.972249, -67.002156),
                    new Position(-17.517854, -66.846974),
                    new Position(-17.591177, -67.055715),
                    new Position(-17.318685, -67.242482),
                    new Position(-17.863257, -67.780812),
                    new Position(-17.601649, -68.352101),
                    new Position(-18.030486, -69.066213),
                    new Position(-17.271482, -69.618276),
                    new Position(-17.271482, -69.618276),
                    new Position(-16.330189, -68.799794),
                    new Position(-16.113936, -69.277699),
                    new Position(-15.622541, -69.420522),
                    new Position(-15.262492, -69.129384),
                    new Position(-14.806252, -69.353230),
                    new Position(-14.745170, -69.229634),
                    new Position(-14.221290, -68.831380),
                    new Position(-13.656163, -69.064839),
                    new Position(-13.212707, -68.856099),
                    new Position(-12.878246, -68.869832),
                    new Position(-12.537975, -68.658345),



                }
            };


            ciudad.Add(datos);
            datos = new Departamento() { 
                Nombre = "COCHABAMBA", 
                Latitud = -17.2308615,
                Longitud = -65.6199238,
                Poligon = new List<Position>(){
                    new Position(-15.777259, -66.853139),
                    new Position(-16.347357, -66.187093),
                    new Position(-16.484358, -65.884969),
                    new Position(-16.368441, -65.239522),
                    new Position(-16.186523, -65.115926),
                    new Position(-15.909371, -65.080220),
                    new Position(-15.803688, -64.967611),
                    new Position(-15.806331, -64.734151),
                    new Position(-16.378981, -64.659993),
                    new Position(-16.768586, -64.835775),
                    new Position(-16.997240, -64.690206),
                    new Position(-17.306922, -64.253499),
                    new Position(-17.385572, -64.231527),
                    new Position(-17.451088, -64.399068),
                    new Position(-17.558483, -64.437520),
                    new Position(-17.555864, -64.607808),
                    new Position(-17.702449, -64.646261),
                    new Position(-17.736461, -64.756124),
                    new Position(-17.943008, -64.811055),
                    new Position(-18.097107, -64.698446),
                    new Position(-18.498693, -64.302938),
                    new Position(-18.657504, -64.335897),
                    new Position(-18.615863, -64.363363),
                    new Position(-18.665311, -64.561116),
                    new Position(-18.535155, -64.692952),
                    new Position(-18.483065, -64.857747),
                    new Position(-18.667913, -65.047261),
                    new Position(-18.597642, -65.250509),
                    new Position(-17.966523, -65.862996),
                    new Position(-17.990036, -65.937154),
                    new Position(-17.812310, -66.099202),
                    new Position(-18.133654, -66.787908),
                    new Position(-18.048803, -66.838720),
                    new Position(-17.886820, -66.713750),
                    new Position(-17.588595, -66.897771),
                    new Position(-17.493006, -66.817434),
                    new Position(-16.942073, -67.009694),
                    new Position(-16.752807, -66.740529),
                    new Position(-16.094182, -66.910817),
                    new Position(-15.935783, -66.888845),
                    new Position(-15.782545, -66.888845)

                }
            };
            ciudad.Add(datos);
            datos = new Departamento() {
                Nombre = "TARIJA", 
                Latitud = -21.1308592,
                
                Longitud = -63.7731223,
                Poligon=new List<Position>(){
                new Position(-20.997581, -64.012075),
                new Position(-20.989888, -62.270742),
                new Position(-21.061672, -62.259756),
                new Position(-22.225784, -62.641531),
                new Position(-22.159663, -62.798086),
                new Position(-21.994225, -62.817312),
                new Position(-21.996771, -63.935171),
                new Position(-22.657341, -64.270254),
                new Position(-22.867553, -64.322439),
                new Position(-22.538163, -64.413076),
                new Position(-22.368092, -64.566884),
                new Position(-22.281708, -64.533925),
                new Position(-22.182554, -64.649282),
                new Position(-22.078241, -64.995351),
                new Position(-22.078241, -65.195852),
                new Position(-22.017143, -65.187612),
                new Position(-21.892321, -65.421071),
                new Position(-21.616816, -65.259023),
                new Position(-20.946288, -65.171133),
                new Position(-21.097551, -64.797597),
                new Position(-20.930897, -64.706274),
                new Position(-21.092426, -64.534612),
                new Position(-21.082175, -64.454961),
                new Position(-21.146230, -64.346471),
                new Position(-21.139826, -64.205022),
                new Position(-20.885996, -64.172063),
                new Position(-20.953983, -64.014135)}
            };
            ciudad.Add(datos);
            datos = new Departamento() { Nombre = "POTOSI" ,Latitud = -20.4057577,
                 Longitud = -66.6617328,
            Poligon=new List<Position>() {
                new Position(-19.427077, -68.416799),
                new Position(-19.884892, -67.572225),
                new Position(-19.709163, -67.562612),
                new Position(-19.750529, -67.276967),
                new Position(-19.662614, -67.205556),
                new Position(-19.414126, -67.260488),
                new Position(-19.452977, -66.381581),
                new Position(-19.105575, -66.095937),
                new Position(-18.689811, -66.447499),
                new Position(-18.767845, -66.529897),
                new Position(-18.335605, -66.733144),
                new Position(-18.241723, -66.524404),
                new Position(-18.231288, -66.753743),
                new Position(-18.133434, -66.764043),
                new Position(-18.061640, -66.528524),
            new Position(-17.912736, -66.163228),
            new Position(-17.802938, -66.097310),
            new Position(-17.972835, -65.858358),
            new Position(-18.424225, -65.352986),
            new Position(-18.348641, -65.693563),
            new Position(-18.635165, -65.391439),
            new Position(-18.939393, -65.402425),
            new Position(-18.991343, -65.583699),
            new Position(-19.167851, -65.396932),
            new Position(-19.367491, -65.174459),
            new Position(-19.362309, -64.916280),
            new Position(-19.776377, -64.718526),
            new Position(-19.972684, -64.875081),

            new Position(-19.794468, -65.050862),
            new Position(-20.016562, -65.097554),
            new Position(-19.933959, -65.226644),
            new Position(-21.498417, -65.401052),
            new Position(-21.493306, -65.258229),
            new Position(-21.886331, -65.423024),
            new Position(-22.074804, -65.192311),
            new Position(-22.105344, -65.758107),
            new Position(-21.784350, -66.230519),
            new Position(-22.084985, -66.307424),
            new Position(-22.227436, -66.741384),
            new Position(-22.790723, -67.191823),
            new Position(-22.836294, -67.883962),
            new Position(-20.935129, -68.405812),
            new Position(-20.873550, -68.570607),
                new Position(-20.637263, -68.460744),
                new Position(-20.359415, -68.746388

),
            new Position(-20.050107, -68.581594

),
            new Position(-19.848729, -68.537648

),
            }
            };
            ciudad.Add(datos);
            datos = new Departamento() { Nombre = "BENI" ,Latitud = -13.4364345,
                 Longitud = -64.545056,
            Poligon=new List<Position>() {
                new Position(-10.381178, -65.392376),
                new Position(-11.693989, -65.259167),
                new Position(-11.693989, -65.099866),
                new Position(-11.989683, -65.011975),
                new Position(-12.456753, -64.303357),
                new Position(-12.515748, -63.935315),
                new Position(-12.424568, -63.759534),
                new Position(-13.137052, -62.254407),
                new Position(-13.511222, -61.880871),
                new Position(-13.516563, -61.545788),
                new Position(-14.292392, -63.565899),
                new Position(-14.733775, -63.977887),
                new Position(-14.765648, -63.931195),
                new Position(-15.017809, -63.925702),
                new Position(-15.505356, -63.677136),
                new Position(-15.875548, -63.396985),
                new Position(-15.801564, -64.962536),
                new Position(-15.907248, -65.072400),
                new Position(-16.202866, -65.127331),
                new Position(-16.361052, -65.237195),
                new Position(-16.487508, -65.879895),
                new Position(-16.287248, -66.225964),
                new Position(-15.378279, -67.115857),
                new Position(-14.592947, -67.527844),

                new Position(-13.772793, -67.511364),
                new Position(-13.569967, -67.363049),
                new Position(-12.826592, -66.962048),
                new Position(-11.747775, -66.907116),
                new Position(-11.650953, -66.703869),
                new Position(-11.451822, -66.725842),
                new Position(-11.295649, -66.253430),
                new Position(-10.805041, -66.011731),

            }
            };
            ciudad.Add(datos);
            datos = new Departamento() {Nombre = "PANDO" ,
                Latitud = -11.0840364,
                Longitud = -67.4307789,
                Poligon =
                new List<Position>() {
                    new Position(-10.938452, -69.581353),
                    new Position(-11.003165, -68.757378),
                    new Position(-11.137938, -68.724419),
                    new Position(-10.960024, -68.246514),
                    new Position(-10.652467, -68.026787),
                    new Position(-10.701049, -67.708184),
                    new Position(-10.317578, -67.180840),
                    new Position(-9.939049, -66.648003),
                    new Position(-9.760447, -65.741631),
                    new Position(-9.830817, -65.560357),
                    new Position(-9.673817, -65.401055),
                    new Position(-10.285150, -65.315911),
                    new Position(-10.825169, -66.057488),
                    new Position(-11.310357, -66.260735),
                    new Position(-11.450372, -66.722161),
                    new Position(-11.859244, -66.952874),
                    new Position(-12.460671, -66.974846),
                    new Position(-11.848492, -67.999321),
                    new Position(-11.939870, -67.982842),
                    new Position(-12.025846, -68.114678),
                    new Position(-12.009728, -68.235527),
                    new Position(-12.208452, -68.279473),
                    new Position(-12.262136, -68.422295),
                    new Position(-12.412393, -68.482720),
                    new Position(-12.492852, -68.658501)
                }
            };
            ciudad.Add(datos);
            datos = new Departamento() { Nombre = "CHUQUISACA", Latitud = -19.9321658,
                 Longitud = -63.9371016,
                Poligon=new List<Position>() {
                
                new Position(-20.447726, -62.228728),
                new Position(-20.982080, -62.272673),
                new Position(-20.992338, -63.997526),
                new Position(-20.879467, -64.184294),
                new Position(-21.135869, -64.228239),
                new Position(-20.930782, -64.722624),
                new Position(-21.084624, -64.843474),
                new Position(-20.920521, -65.184050),
                new Position(-21.453192, -65.260954),
                new Position(-21.463417, -65.439482),
                new Position(-20.853802, -65.346098),
                new Position(-20.545489, -65.384550),
                new Position(-20.318997, -65.219755),
                new Position(-20.019931, -65.302153),
                new Position(-19.932166, -65.208769),
                new Position(-20.009608, -65.164824),
                new Position(-19.957984, -65.076933),
                new Position(-19.792674, -65.043974),
                new Position(-19.973473, -64.851713),
                new Position(-19.771998, -64.714384),
                new Position(-19.378648, -64.901152),
                new Position(-19.264605, -65.368071),
                new Position(-18.989540, -65.587797),
                new Position(-18.916805, -65.401030),
                new Position(-18.609933, -65.406523),
                new Position(-18.490154, -65.615263),
                new Position(-18.349437, -65.681181),
                new Position(-18.510991, -65.252714),
                new Position(-18.599521, -65.258208),
                new Position(-18.656780, -65.049467),
                new Position(-18.495364, -64.802275),
                new Position(-18.672393, -64.544096),
                new Position(-18.615139, -64.357329),
                new Position(-19.166049, -64.022246),
                new Position(-19.150483, -63.906889),
                new Position(-19.036281, -63.890410),
                new Position(-19.041474, -63.733855),
                new Position(-20.458020, -63.689909)

            } };
            ciudad.Add(datos);
            datos = new Departamento() { Nombre = "ORURO" ,Latitud = -18.605321,
                 Longitud = -67.6142227,
                Poligon=new List<Position>() {
                    new Position(-18.146573, -69.144069),
                    new Position(-18.036920, -69.078151),
                    new Position(-17.916745, -68.759547),
                    new Position(-17.806949, -68.538448),
                    new Position(-17.702318, -68.538448),
                    new Position(-17.869698, -67.810603),
                    new Position(-17.660449, -67.511226),
                    new Position(-17.576681, -67.549678),
                    new Position(-17.505972, -67.470027),
                    new Position(-17.568826, -67.409602),
                    new Position(-17.325145, -67.253047),
                    new Position(-17.521687, -67.022334),
                    new Position(-17.589773, -67.049800),
                    new Position(-17.629041, -67.005855),
                    new Position(-17.592391, -66.898738),
                    new Position(-17.882768, -66.711971),
                    new Position(-18.055200, -66.846553),
                    new Position(-18.232681, -66.750423),
                    new Position(-18.245724, -66.527950),
                    new Position(-18.339604, -66.728450),
                    new Position(-18.782236, -66.514217),
                    new Position(-18.709411, -66.401607), 
                    new Position(-19.008311, -66.291743),
                    new Position(-18.982341, -66.187373),
                    new Position(-19.099175, -66.091243),
                    new Position(-19.244453, -66.129695),
                    new Position(-19.301491, -66.272517),
                    new Position(-19.451770, -66.387874),
                    new Position(-19.363692, -66.508723),
                    new Position(-19.451770, -66.849300),
                    new Position(-19.358510, -67.085506),
                    new Position(-19.451770, -67.195369),
                    new Position(-19.428460, -67.269527),
                    new Position(-19.676927, -67.209102),
                    new Position(-19.754494, -67.288753),
                    new Position(-19.718301, -67.577144),
                    new Position(-19.837191, -67.524959),
                    new Position(-19.052451, -68.881770),
                    new Position(-18.922594, -68.954555),
                    new Position(-18.313532, -69.042445),
                    new Position(-18.219637, -69.069911)
                }
            };
            ciudad.Add(datos);
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
