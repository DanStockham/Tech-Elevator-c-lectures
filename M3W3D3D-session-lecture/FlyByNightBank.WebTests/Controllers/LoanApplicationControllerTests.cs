using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlyByNightBank.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using FlyByNightBank.Web.Models;
using System.Web;
using Moq;
using System.Web.Routing;
using FlyByNightBank.Web.DAL;

namespace FlyByNightBank.Web.Controllers.Tests
{
    /*
    * The objective of these tests will be to test each of the controller actions and check
    * to see if they return the correct view, redirect to the correct action, or save to our database.
    * 
    * Unfortunately unit testing controllers that rely on Session is difficult. ASP.NET MVC expects a 
    * request context and a session to exist (which only does when we browse to our site). Therefore
    * we need to "mock" a session object. The code is complicated and relies on a library called Moq.
    */
    [TestClass()]
    public class LoanApplicationControllerTests
    {
        private readonly IApplicationDAL applicationDal;
        /*
        * TEST: Index action (HTTP GET)
        *   returns Index ViewResult        
        */
        [TestMethod()]
        public void Index_Get()
        {
            LoanApplicationController controller = new LoanApplicationController(applicationDal);

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result, "Result returned was not of type ViewResult");
            Assert.AreEqual("Index", result.ViewName);
        }




        /*
        * TEST: Start action (HTTP GET) 
        *   returns Start ViewResult
        */
        [TestMethod()]
        public void Start_Get()
        {
            LoanApplicationController controller = new LoanApplicationController(null);

            ViewResult result = controller.Start() as ViewResult;

            Assert.IsNotNull(result, "Result returned was not of type ViewResult");
            Assert.AreEqual("Start", result.ViewName);
        }



        /*
        * TEST: Start action (HTTP POST) 
        *   returns Redirect to PersonalContactInformation Action
        */
        [TestMethod()]
        public void Start_Post()
        {
            // Arrange
            LoanApplicationController controller = new LoanApplicationController(null);
            LoanApplication application = new LoanApplication()
            {
                FirstName = "Test",
                LastName = "Test",
                LogonUsername = "test@test.com"
            };

            #region Mocking Controller Request                        
            // Mock Session Object
            Mock<HttpSessionStateBase> mockSession = new Mock<HttpSessionStateBase>();
            
            // Mock Http Context Request for Controller
            // because Session doesn't exist unless MVC actually receives a "request"
            Mock<HttpContextBase> mockContext = new Mock<HttpContextBase>();

            // When the Controller calls this.Session it will get a mock session
            mockContext.Setup(c => c.Session).Returns(mockSession.Object);

            // Assign the context property on the controller to our mock context which uses our mock session
            controller.ControllerContext = new ControllerContext(mockContext.Object, new RouteData(), controller);

            // For more details: https://dontpaniclabs.com/blog/post/2011/03/22/testing-session-in-mvc-in-four-lines-of-code/

            #endregion

            // Act
            RedirectToRouteResult result = controller.Start(application) as RedirectToRouteResult;

            // Assert
            Assert.IsNotNull(result, "Result returned was not of type RedirectToRouteResult");
            Assert.AreEqual("PersonalContactInformation", result.RouteValues["action"]);
        }





        /*
        * TEST: PersonalContactInfo action (HTTP GET) 
        *   returns ViewResult        
        */
        [TestMethod()]
        public void PersonalContactInfo_Get()
        {
            LoanApplicationController controller = new LoanApplicationController(null);

            ViewResult result = controller.PersonalContactInformation() as ViewResult;

            Assert.IsNotNull(result, "Result returned was not of type ViewResult");
            Assert.AreEqual("PersonalContactInformation", result.ViewName);
        }

        /*
        * TEST: PersonalContactInfo action (HTTP POST)
        *   returns RedirectToRouteResult
        */
        [TestMethod()]
        public void PersonalContactInfo_Post()
        {
            LoanApplicationController controller = new LoanApplicationController(null);
            LoanApplication application = new LoanApplication()
            {
                HomeAddress = "test address",
                HomeCity = "test city",
                HomePhone = "test phone",
                HomeState = "test state",
                HomePostalCode = "test postal"
            };

            #region Mocking Controller Request                        
            // Mock Session Object
            Mock<HttpSessionStateBase> mockSession = new Mock<HttpSessionStateBase>();

            // Mock Http Context Request for Controller
            // because Session doesn't exist unless MVC actually receives a "request"
            Mock<HttpContextBase> mockContext = new Mock<HttpContextBase>();

            // When the Controller calls this.Session it will get a mock session
            mockContext.Setup(c => c.Session).Returns(mockSession.Object);

            // Assign the context property on the controller to our mock context which uses our mock session
            controller.ControllerContext = new ControllerContext(mockContext.Object, new RouteData(), controller);

            // For more details: https://dontpaniclabs.com/blog/post/2011/03/22/testing-session-in-mvc-in-four-lines-of-code/

            #endregion

            RedirectToRouteResult result = controller.PersonalContactInformation(application) as RedirectToRouteResult;

            Assert.IsNotNull(result, "Result returned was not of type RedirectToRouteResult");
            Assert.AreEqual("WorkContactInformation", result.RouteValues["action"]);
        }





        /*
        * TEST: PersonalContactInfo action (HTTP GET) 
        *   returns ViewResult        
        */
        [TestMethod()]
        public void WorkContactInfo_Get()
        {
            LoanApplicationController controller = new LoanApplicationController(null);

            ViewResult result = controller.WorkContactInformation() as ViewResult;

            Assert.IsNotNull(result, "Result returned was not of type ViewResult");
            Assert.AreEqual("WorkContactInformation", result.ViewName);
        }

        /*
        * TEST: PersonalContactInfo action (HTTP POST)
        *   returns RedirectToRouteResult
        */
        [TestMethod()]
        public void WorkContactInfo_Post()
        {
            LoanApplicationController controller = new LoanApplicationController(null);
            LoanApplication application = new LoanApplication()
            {
                WorkAddress = "test address",
                WorkCity = "test city",
                WorkPhone = "test phone",
                WorkState = "test state",
                WorkPostalCode = "test postal",
                JobTitle = "test title"
            };

            #region Mocking Controller Request                        
            // Mock Session Object
            Mock<HttpSessionStateBase> mockSession = new Mock<HttpSessionStateBase>();

            // Mock Http Context Request for Controller
            // because Session doesn't exist unless MVC actually receives a "request"
            Mock<HttpContextBase> mockContext = new Mock<HttpContextBase>();

            // When the Controller calls this.Session it will get a mock session
            mockContext.Setup(c => c.Session).Returns(mockSession.Object);

            // Assign the context property on the controller to our mock context which uses our mock session
            controller.ControllerContext = new ControllerContext(mockContext.Object, new RouteData(), controller);

            // For more details: https://dontpaniclabs.com/blog/post/2011/03/22/testing-session-in-mvc-in-four-lines-of-code/

            #endregion

            RedirectToRouteResult result = controller.WorkContactInformation(application) as RedirectToRouteResult;

            Assert.IsNotNull(result, "Result returned was not of type RedirectToRouteResult");
            Assert.AreEqual("FinancialInformation", result.RouteValues["action"]);
        }

        /*
        * TEST: PersonalContactInfo action (HTTP GET) 
        *   returns ViewResult        
        */
        [TestMethod()]
        public void FinancialInfo_Get()
        {
            LoanApplicationController controller = new LoanApplicationController(null);

            ViewResult result = controller.FinancialInformation() as ViewResult;

            Assert.IsNotNull(result, "Result returned was not of type ViewResult");
            Assert.AreEqual("FinancialInformation", result.ViewName);
        }


        /*
        * TEST: PersonalContactInfo action (HTTP POST)
        *   returns RedirectToRouteResult
        */
        [TestMethod()]
        public void FinancialInfo_Post()
        {
            LoanApplicationController controller = new LoanApplicationController(null);
            LoanApplication application = new LoanApplication()
            {
                NetWorth = 100000,
                Reference1Name = "test reference",
                Reference1Phone = "test reference phone"
            };

            #region Mocking Controller Request                        
            // Mock Session Object
            Mock<HttpSessionStateBase> mockSession = new Mock<HttpSessionStateBase>();

            // Mock Http Context Request for Controller
            // because Session doesn't exist unless MVC actually receives a "request"
            Mock<HttpContextBase> mockContext = new Mock<HttpContextBase>();

            // When the Controller calls this.Session it will get a mock session
            mockContext.Setup(c => c.Session).Returns(mockSession.Object);

            // Assign the context property on the controller to our mock context which uses our mock session
            controller.ControllerContext = new ControllerContext(mockContext.Object, new RouteData(), controller);

            // For more details: https://dontpaniclabs.com/blog/post/2011/03/22/testing-session-in-mvc-in-four-lines-of-code/

            #endregion

            RedirectToRouteResult result = controller.FinancialInformation(application) as RedirectToRouteResult;

            Assert.IsNotNull(result, "Result returned was not of type RedirectToRouteResult");
            Assert.AreEqual("Review", result.RouteValues["action"]);
        }


        /*
        * TEST: Review action (HTTP GET) 
        *   returns ViewResult        
        */
        [TestMethod()]
        public void Review_Get()
        {
            LoanApplicationController controller = new LoanApplicationController(null);

            #region Mocking Controller Request                        
            // Mock Session Object
            Mock<HttpSessionStateBase> mockSession = new Mock<HttpSessionStateBase>();
            mockSession.SetupGet(p => p["Loan_Application"]).Returns(new LoanApplication());

            // Mock Http Context Request for Controller
            // because Session doesn't exist unless MVC actually receives a "request"
            Mock<HttpContextBase> mockContext = new Mock<HttpContextBase>();

            // When the Controller calls this.Session it will get a mock session
            mockContext.Setup(c => c.Session).Returns(mockSession.Object);

            // Assign the context property on the controller to our mock context which uses our mock session
            controller.ControllerContext = new ControllerContext(mockContext.Object, new RouteData(), controller);

            // For more details: https://dontpaniclabs.com/blog/post/2011/03/22/testing-session-in-mvc-in-four-lines-of-code/

            #endregion

            ViewResult result = controller.Review() as ViewResult;

            Assert.IsNotNull(result, "Result returned was not of type ViewResult");
            Assert.AreEqual("Review", result.ViewName);
            Assert.IsNotNull(result.Model);
        }


        /*
        * TEST: Submit action (HTTP POST) 
        *   returns RedirectToRouteResult        
        */
        [TestMethod()]
        public void Submit_Post()
        {
            //Arrange
            #region Mocking
            Mock<IApplicationDAL> mockDal = new Mock<IApplicationDAL>();
            mockDal.Setup(m => m.SubmitApplication(It.IsAny<LoanApplication>())).Returns(true);
            #endregion
            LoanApplicationController controller = new LoanApplicationController(mockDal.Object);
            #region Mocking Controller Request                        
            // Mock Session Object
            Mock<HttpSessionStateBase> mockSession = new Mock<HttpSessionStateBase>();
            mockSession.SetupGet(p => p["Loan_Application"]).Returns(new LoanApplication());

            // Mock Http Context Request for Controller
            // because Session doesn't exist unless MVC actually receives a "request"
            Mock<HttpContextBase> mockContext = new Mock<HttpContextBase>();

            // When the Controller calls this.Session it will get a mock session
            mockContext.Setup(c => c.Session).Returns(mockSession.Object);

            // Assign the context property on the controller to our mock context which uses our mock session
            controller.ControllerContext = new ControllerContext(mockContext.Object, new RouteData(), controller);

            // For more details: https://dontpaniclabs.com/blog/post/2011/03/22/testing-session-in-mvc-in-four-lines-of-code/

            #endregion

            //Act
            RedirectToRouteResult result = controller.Submit() as RedirectToRouteResult;

            //Assert
            Assert.IsNotNull(result, "Result returned was not of type RedirectToRouteResult");
            Assert.AreEqual("Submitted", result.RouteValues["action"]);
            mockDal.Verify(m => m.SubmitApplication(It.IsAny<LoanApplication>()));
        }
    }
}