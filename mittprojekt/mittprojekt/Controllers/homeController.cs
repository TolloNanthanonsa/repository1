using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mittprojekt.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/
        public ActionResult Index()
        {
            Random r = new Random();
            int slumpattal = r.Next(0, 100);

            return View(slumpattal);
        }
        public ActionResult minsidatextpåallasidor()
        {
            Random r = new Random();
            int slumpattal = r.Next(0, 100);

            return View(slumpattal);
        }
        /*
        public ActionResult minsidatextpåallasidor()  // gör en väder API 
        {
            Random r = new Random();
            int slumpattal = r.Next(0, 100);

            return View(slumpattal);
        }
        */
	}
}