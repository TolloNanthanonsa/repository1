using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mittprojekt.Models
{
    public class Weather       //list of           
    {
        public double Temperature { get; set; }  //properties variables, just like  normal variables
        public double Humidity { get; set; }
        
        public double airpressure { get; set; }
        public double windspeed { get; set; }  
        public double rain { get; set; }

        public double snow { get; set; }

    }
}