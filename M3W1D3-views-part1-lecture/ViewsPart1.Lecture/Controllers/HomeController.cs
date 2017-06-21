using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsPart1.Lecture.Controllers
{
    /*
    * Each Controller Action below responds to a request from a browser.
    * If the user visits http://localhost/Home/HelloInternet then the
    * HelloInternet Action will execute, returning the HelloInternet view.
    */
    public class HomeController : Controller
    {
        // GET: Home/Index
        // GET: Home/
        // GET: <no path>
        public string Index()
        {
            return "Hello World,class!";
        }              
    
        // GET: Home/Welcome
        public ActionResult Welcome()
        {
            return View("Welcome");
        }

        // GET: Home/HelloInternet
        public ActionResult HelloInternet()
        {
            return View("HelloInternet");
        }

        
        // GET: Home/MetricToImperial
        public ActionResult MetricToImperial()
        {
            return View("MetricToImperial");
        }
    }
}