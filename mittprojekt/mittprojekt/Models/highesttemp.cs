using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mittprojekt.Models
{
    public class highesttemp
    {
        public double AverageTemperature { get; set; }        //Average temperature
        public double HighestTemperature { get; set; }        //The highest temperature in skåne 
        public string CityWithHighestTemperature { get; set; }  //Where is the highest temperature
    }
} //en klass som ska göra någonting, public double