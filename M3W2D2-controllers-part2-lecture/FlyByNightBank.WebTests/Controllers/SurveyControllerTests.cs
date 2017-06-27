using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlyByNightBank.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using FlyByNightBank.Web.DAL;
using Moq;
using FlyByNightBank.Web.Models;

namespace FlyByNightBank.Web.Controllers.Tests
{

    /*
    * The objective of these tests will be to test each of the controller actions and check
    * to see if they return the correct view, redirect to the correct action, or save to our database.
    */
    [TestClass()]
    public class SurveyControllerTests
    {
        /*
        * TEST: Index Action (HTTP GET)
        *   returns Index ViewResult
        */
        [TestMethod()]
        public void Index_HttpGet_ReturnsCorrectView()
        {
            SurveyController controller = new SurveyController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ViewName);
        }
    }
}