using Covid19_Bolivia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Covid19_Bolivia.ViewModels
{
    class DatosViewModel:INotifyPropertyChanged
    {
        public List<Datos> ciudad { get; set; }
        public Datos datos { get; set; }
        public DatosViewModel()
        {
             
            
            ciudad = new List<Datos>();
            datos = new Datos() { Departamento = "SANTA CRUZ", Latitud=-17.8145819,Longitud=-63.1560853 };
            ciudad.Add(datos);
            datos = new Datos() { Departamento = "LA PAZ", Latitud=-16.489689,Longitud=-68.1192936 };
            ciudad.Add(datos);
            datos = new Datos() { Departamento = "COCHABAMBA", Latitud = -17.4139766 , Longitud = -66.1653224 };
            ciudad.Add(datos);
            datos = new Datos() { Departamento = "TARIJA", Latitud = -21.5177889, Longitud = -64.7295667 };
            ciudad.Add(datos);
            datos = new Datos() { Departamento = "POTOSI" ,Latitud = -19.5722805, Longitud = -65.7550063 };
            ciudad.Add(datos);
            datos = new Datos() { Departamento = "BENI" ,Latitud = -14.3782747, Longitud = -65.09557792 };
            ciudad.Add(datos);
            datos = new Datos() { Departamento = "PANDO" ,Latitud = -10.7988901, Longitud = -66.9988011 };
            ciudad.Add(datos);
            datos = new Datos() { Departamento = "CHUQUISACA", Latitud = -20.8044866, Longitud = -64.1478236 };
            ciudad.Add(datos);
            datos = new Datos() { Departamento = "ORURO" ,Latitud = -17.9716723, Longitud = -67.0931378 };
            ciudad.Add(datos);


        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
