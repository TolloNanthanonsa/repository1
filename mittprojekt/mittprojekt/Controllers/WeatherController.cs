using mittprojekt.Helpers;
using mittprojekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace mittprojekt.Controllers
{
    public class WeatherController : Controller
    {
        //
        // GET: /Weather/
        public ActionResult Index(string city)
        {
            //loads temperature to given location the +city 

            string json = new WebClient().DownloadString("http://api.openweathermap.org/data/2.5/weather?q="+city); //downloads string from link, city = value from dropdown menu
            

            var serializer = new JavaScriptSerializer();
            serializer.RegisterConverters(new[] { new DynamicJsonConverter() });

            dynamic obj = serializer.Deserialize(json, typeof(object));


            double temperature = Convert.ToDouble(obj.main.temp) - 273.15;  //substracts to celsius 
            temperature = Math.Round(temperature, 2);                       //rounds numbers to digits 

            Weather myWeather = new Weather();                              
            myWeather.Temperature = temperature;                            //linked to above two rows of code
            myWeather.Humidity = Convert.ToDouble(obj.main.humidity);       
            myWeather.airpressure = Convert.ToDouble(obj.main.pressure);
            myWeather.windspeed = Convert.ToDouble(obj.wind.speed);
            //myWeather.rain = Convert.ToDouble(obj.rain.3h); 
            //myWeather.snow = Convert.ToDouble(obj.snow.3h); 


            return View(myWeather);                                         //returns results vellinge to view

           
        }
        
        
        
        
        public ActionResult AverageTemperature()
        {
            List<string> cities = new List<string>() { "Vellinge,se ", "Malmo,se", "Trelleborg,se", "Ystad,se", "Helsingborg,se", "Kristianstad.se", 
                "Landskrona,se", "Simrishamn,se", "Lund,se", "Ängelholm,se"};//list of cities to be averaged 

            var serializer = new JavaScriptSerializer();
            serializer.RegisterConverters(new[] { new DynamicJsonConverter() });


            double TotalTemperature = 0;  
            foreach(string city in cities)
            {
                string json = new WebClient().DownloadString("http://api.openweathermap.org/data/2.5/weather?q="+city); //downloads string from link 
                dynamic obj = serializer.Deserialize(json, typeof(object));
                TotalTemperature += Convert.ToDouble(obj.main.temp) - 273.15;
            }

            double averageTemp = TotalTemperature / 10; //divides total value with 3 
           

            return View(averageTemp);            
        }
        
	}
}