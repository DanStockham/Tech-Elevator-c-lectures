using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlyByNightBank.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using FlyByNightBank.Web.Models.Calculators;

namespace FlyByNightBank.Web.Controllers.Tests
{

    [TestClass()]
    public class CalculatorsControllerTests
    {
        /*
        * TEST
        * Check that CompoundInterest() returns the correct view.
        */
        [TestMethod()]
        public void CompoundInterest_ReturnsCorrectView()
        {
            //Arrange
            CalculatorsController controller = new CalculatorsController();

            //Act
            // CompoundInterest() returns ActionResult
            // Cast ActionResult to ViewResult
            ViewResult result = controller.CompoundInterest() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("CompoundInterest", result.ViewName);
        }

        /*
        * TEST
        * Check that CompoundInterestResult() returns the correct view and its inputs are passed to the model.
        */
        [TestMethod]
        public void CompoundInterestResult_ReturnsCorrectViewAndModel()
        {
            //Arrange
            CalculatorsController controller = new CalculatorsController();

            //Act
            ViewResult result = controller.CompoundInterestResult(100, 10, 10) as ViewResult;

            //Assert
            Assert.IsNotNull(result); //... a ViewResult is returned
            Assert.AreEqual("CompoundInterestResult", result.ViewName); //... the View's  name is CompoundInterestResult
            Assert.IsNotNull(result.Model);     // View returns a model //... the View is bound with a model
            Assert.IsNotNull(result.Model as CompoundInterestModel); //... the View's Model is a CompoundInterestCalculator
        }

        /*
        * TEST
        * Check that TimeToPayoff() returns the correct view
        */
        [TestMethod]
        public void TimeToPayOff_ReturnsCorrectView()
        {
            //Arrange
            CalculatorsController controller = new CalculatorsController();

            //Act
            // CompoundInterest() returns ActionResult
            // Cast ActionResult to ViewResult
            ViewResult result = controller.TimeToPayOff() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("TimeToPayOff", result.ViewName);
        }

        /*
        * TEST
        * Check that TimeToPayOffResult() returns the correct view and model.
        */
        [TestMethod]
        public void TimeToPayOffResult_ReturnsCorrectViewAndModel()
        {
            //Arrange
            CalculatorsController controller = new CalculatorsController();

            //Act
            ViewResult result = controller.TimeToPayOffResult(new CreditCardPayoffModel()) as ViewResult;

            //Assert
            Assert.IsNotNull(result); //... a ViewResult is returned
            Assert.AreEqual("TimeToPayOffResult", result.ViewName); //... the View's  name is CompoundInterestResult
            Assert.IsNotNull(result.Model);     // View returns a model //... the View is bound with a model
            Assert.IsNotNull(result.Model as CreditCardPayoffModel); //... the View's Model is a CompoundInterestCalculator

        }
    }
}