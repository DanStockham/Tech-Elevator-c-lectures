using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        //GET 
        //GET /Home
        //GET /Home/Index
        public ActionResult Index()
        {
            return View();
        }

        //GET /Home/About
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Browser = Url.RequestContext.HttpContext.Request.UserAgent;

            return View();
        }

        //GET /Home/Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // GET /Home/Helpers/
        public ActionResult Helpers()
        {
            ViewBag.Message = "Helper page.";
            Person person = GetPerson();
            return View(person);
        }

        // Get /Home/HelpersUpdate
        [HttpGet]
        public ActionResult HelpersUpdate()
        {
            ViewBag.Message = "Helper page.";
            Person person = new Models.Person();
            person.FirstName = Request.Params["First"];
            person.LastName = Request.Params["Last"];

            if (Request["Driver"] != null)
            {
                string result = Request["Driver"];
                if (result.Contains("true"))
                {
                    person.LicensedDriver = true;
                }
            }

            if (Request["FavoriteColor"] != null)
            {
                string result = Request["FavoriteColor"];
                person.FavoriteColor = result;
            }
            else
            {
                person.FavoriteColor = "Red";
            }

            person.BirthYear = int.Parse(Request.Params["Birth"]);

            return View("Helpers", person);
        }

        //GET /Home/Input
        public ActionResult Input()
        {
            //System.Collections.Specialized.NameValueCollection parameters = Url.RequestContext.HttpContext.Request.Params;
            string name;
            if ((Request.Params["fname_name"] == null) || (Request.Params["fname_name"] == null))
            {
                name = "";
            }
            else
            {
                name = Request.Params["fname_name"] + " " + Request.Params["lname_name"];
            }
            ViewBag.Name = name;

            return View();
        }

        //GET /Home/Search
        public ActionResult Search()
        {
            //System.Collections.Specialized.NameValueCollection parameters = Url.RequestContext.HttpContext.Request.Params;
            string response;
            if (Request.Params["q"] == null)
            {
                response = "";
            }
            else if (Request.Params["q"].ToLower() == "john")
            {
                response = "John Fulton";
            }
            else if (Request.Params["q"].ToLower() == "lisa")
            {
                response = "Lisa Bruegge-Fulton";
            }
            else
            {
                response = "some other person";
            }
            ViewBag.Response = response;

            return View();
        }

        private Person GetPerson()
        {
            Person p1 = new Models.Person();
            p1.FirstName = "John";
            p1.LastName = "Fulton";
            p1.BirthYear = 1953;
            p1.LicensedDriver = true;
            p1.FavoriteColor = "Blue";

            return p1;
        }
    }
}