using mittprojekt.Helpers;
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
        public ActionResult Index()
        {
            //laddar temperatur för vellinge

            string json = new WebClient().DownloadString("http://api.openweathermap.org/data/2.5/weather?q=Malmo,se"); //downloads string from link 
            

            var serializer = new JavaScriptSerializer();
            serializer.RegisterConverters(new[] { new DynamicJsonConverter() });

            dynamic obj = serializer.Deserialize(json, typeof(object));


            double temperature = Convert.ToDouble(obj.main.temp) - 273.15;
            temperature = Math.Round(temperature, 2);

            return View(temperature);
        }
	}
}