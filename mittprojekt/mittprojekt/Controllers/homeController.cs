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
        public ActionResult Index()             //random number controller 
        {
            Random r = new Random();
            int randomnumber = r.Next(0, 100);

            return View(randomnumber);
        }
        public ActionResult minsidatextpåallasidor() //links action to view 
        {
            Random r = new Random();
            int randomnumber = r.Next(0, 100);

            return View(randomnumber);                 
        }
        
        public ActionResult slump()  //
        {
            Random r = new Random();
            int randomnumber = r.Next(0, 100);

            return View(randomnumber);
        }
        
	}
}