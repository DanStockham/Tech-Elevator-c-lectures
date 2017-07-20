using jQuery_AJAX_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jQuery_AJAX_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AjaxMethod(string name)
        {
            PersonModel person = new PersonModel
            {
                Name = name,
                DateTime = DateTime.Now.ToString(),
                System = System.Environment.MachineName
            };
            return Json(person);
        }
    }
}