﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRChat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Chat");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Application description page.";

            return View();
        }


        public ActionResult Chat()
        {
            return View();
        }
    }
}