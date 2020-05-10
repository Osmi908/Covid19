using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Covid19_Bolivia.Models;
using Firebase.Database;
using Firebase.Database.Query;
using Xamarin.Forms;

namespace Covid19_Bolivia.Helper
{
    public class FireBaseHelper
    {
        private readonly string ChildName = "Noticia";
        FirebaseClient firebase = new FirebaseClient("https://covid19-bolivia.firebaseio.com/");
        FirebaseClient firebaseMap = new FirebaseClient("https://covid19-bolivia.firebaseio.com/LaPaz");

        public async Task<List<Noticia>> GetAllPersons()
        {
            return (await firebase
                .Child(ChildName)
                .OnceAsync<Noticia>()).Select(item => new Noticia
                {
                    Titulo=item.Object.Titulo,
                    Contenido = item.Object.Contenido,
                    Fecha = item.Object.Fecha,
                    Imagen = item.Object.Imagen
                }).ToList();
        }
        public List<Dato> GetDateMaps(string departamento)
        {
            var e = firebaseMap.Child("Datos");
            var f = e.OnceAsync<Dato>().Result;
            var d = f.Select(item => new Dato
            {
                Sup=item.Object.Sup,
                Departamento = item.Object.Departamento,
                datoC = item.Object.datoC,
                Latitud = item.Object.Latitud,
                Longitud = item.Object.Longitud,
                grado = item.Object.grado,
                Indice = item.Object.Indice,
                id_Dato = item.Object.id_Dato,
                Municipio = item.Object.Municipio
            }).ToList();
            return d;


        }

    }
}
