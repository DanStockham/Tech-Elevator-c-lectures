using FlyByNightBank.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlyByNightBank.Web.Controllers
{
    public class UserController : Controller
    {
        // GET: User/Register
        public ActionResult Register()
        {
            return View("Register");
        }

        // POST: User/Register
        [HttpPost]
        public ActionResult Register(User model)
        {
            // Let's validate the model before proceeding
            if (!ModelState.IsValid)
            {
                return View("Register", model);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}