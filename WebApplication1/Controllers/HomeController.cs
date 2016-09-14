using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Names = new string[]
            {
                "Sylvia",
                "Mark",
                "Matt",
                "Alaric",
                "Eric"
            };

            ViewBag.Name = "This is Sylvia's Page";
            ViewBag.Greeting = "Welcome! Warm Greeting!";
            DateTime today = DateTime.Today;
            if(today.DayOfWeek==DayOfWeek.Friday)
            {
                ViewBag.IfIsFri = "TGIF";
            }
            else
            {
                ViewBag.IfIsFri = "Nope";
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}