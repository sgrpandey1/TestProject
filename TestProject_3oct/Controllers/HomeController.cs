using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestProject_3oct.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "hello";
            return View();
			
        }

        public ActionResult About()
        {
            int i = 7;
            string s = "Welcome" ;
			string name="Adil";
            int age = 22;
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "hi deepak.";

            return View();
        }
    }
}