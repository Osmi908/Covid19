using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps;

namespace Covid19_Bolivia.Renderers
{
    public class CustomPin:Pin
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
