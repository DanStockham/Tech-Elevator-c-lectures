using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlyByNightBank.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FlyByNightBank.Web.Controllers.Tests
{
    [TestClass()]
    public class UserControllerTests
    {
        /*
        * TEST: Register Action (HTTP GET)
        *   returns ViewResult
        */
        [TestMethod()]
        public void Register_Get()
        {
            UserController controller = new UserController();

            ViewResult result = controller.Register() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Register", result.ViewName);
        }

        /*
        * TEST: Register Action (HTTP POST)
        *   returns RedirectToReouteResult
        */
        [TestMethod]
        public void Register_Post_Valid()
        {
            UserController controller = new UserController();
            Models.User model = new Models.User();

            RedirectToRouteResult result = controller.Register(model) as RedirectToRouteResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.RouteValues["action"]);
            Assert.AreEqual("Home", result.RouteValues["controller"]);            
        }


        /*
        * TEST: Register Action (HTTP POST) Invalid Data Model
        *   returns ViewResult
        */
        [TestMethod]
        public void Register_Post_Invalid()
        {
            UserController controller = new UserController();
            controller.ModelState.AddModelError("error", "error");
            Models.User model = new Models.User();

            ViewResult result = controller.Register(model) as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Register", result.ViewName);
        }
    }
}