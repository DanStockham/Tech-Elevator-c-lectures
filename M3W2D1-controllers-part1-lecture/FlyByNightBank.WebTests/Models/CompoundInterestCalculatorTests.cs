using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlyByNightBank.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyByNightBank.Web.Models.Tests
{
    [TestClass()]
    public class CompoundInterestCalculatorTests
    {
        [TestMethod()]
        public void CalculateAmountSavedTest()
        {
            //Arrange
            CompoundInterestCalculator calculator = new CompoundInterestCalculator()
            {
                Principal = 1000.00,
                NumberOfYears = 12,
                InterestRate = 1.5
            };

            //Act
            double result = calculator.CalculateAmountSaved();

            //Assert
            Assert.AreEqual(1195.62, result);
        }
    }
}