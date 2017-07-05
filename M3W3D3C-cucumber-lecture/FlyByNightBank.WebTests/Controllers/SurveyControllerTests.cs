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
    * 
    * One of our tests relies on a ISurveyDAL in order to save the survey. We can "mock" out an ISurveyDAL
    * so that it can be passed in and used in place of the real SQL DAL.
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
            SurveyController controller = new SurveyController(null);

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ViewName);
        }

        /*
        * TEST: Index Action (HTTP POST)
        *   saves record
        *   returns RedirectToRouteResult
        */
        [TestMethod]
        public void Index_HttpPost_SavesRecordAndReturnsRedirect()
        {
            //Arrange
            Mock<ISurveyDAL> mockDal = new Mock<ISurveyDAL>();
            SurveyController controller = new SurveyController(mockDal.Object);
            Survey model = new Survey();

            //Act
            RedirectToRouteResult result = controller.Index(model) as RedirectToRouteResult;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Confirmation", result.RouteValues["action"]);
            mockDal.Verify(m => m.SaveSurvey(model)); //verify that our test called SaveSurvey on the Mock ISurveyDAL
        }

        /*
        * TEST: Confirmation Action (HTTP GET)
        *   returns ViewResult
        */
        [TestMethod]
        public void Confirmation_HttpGet_ReturnsCorrectView()
        {
            SurveyController controller = new SurveyController(null);

            ViewResult result = controller.Confirmation() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Confirmation", result.ViewName);

        }
    }
}