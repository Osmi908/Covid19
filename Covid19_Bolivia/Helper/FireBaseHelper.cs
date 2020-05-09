using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;

namespace Covid19_Bolivia.Helper
{
    public class FireBaseHelper
    {
        private readonly string ChildName = "Noticia";
        FirebaseClient firebase = new FirebaseClient("https://covid19-bolivia.firebaseio.com/");

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

    }
}
