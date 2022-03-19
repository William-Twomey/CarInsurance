using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var currentTime = DateTime.Now.Hour;
            var dayOfWeek = DateTime.Now.DayOfWeek;
            ViewBag.Message = dayOfWeek;
            if (dayOfWeek.ToString() == "Sunday" || dayOfWeek.ToString() == "Saturday")
            {
                ViewBag.IsOpen = "We are closed until Monday";
            }
            else { ViewBag.IsOpen = "Open until Saturday"; }
            return View();
        }
    }
}