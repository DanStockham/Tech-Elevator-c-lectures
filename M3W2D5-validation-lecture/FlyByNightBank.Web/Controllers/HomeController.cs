using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlyByNightBank.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: /
        // GET: Home/
        // GET: Home/Index
        public ActionResult Index()
        {
            return View("Index");
        }


        // GET: Home/WhyFlyByNight
        public ActionResult WhyFlyByNight()
        {
            return View("WhyFlyByNight");
        }
        
    }
}