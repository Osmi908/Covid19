using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace Covid19_Bolivia
{
    public class Noticia
    {
        public string Imagen { get; set; }
        public string  Titulo { get; set; }
        public string Contenido { get; set; }
        public string Fecha { get; set; }
        public Image Img { get; set; }
        public void cambiarImg()
        {
            Img = new Image();
            string base64Image = Imagen;
            byte[] Base64Stream = Convert.FromBase64String(base64Image);
            if (base64Image != "")
            {
                Img.Source = ImageSource.FromStream(() => new MemoryStream(Base64Stream));
            }


        }
    }

}
