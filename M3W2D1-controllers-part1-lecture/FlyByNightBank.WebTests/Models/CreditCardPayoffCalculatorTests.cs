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
    public class CreditCardPayoffCalculatorTests
    {
        [TestMethod()]
        public void GetNumberOfMonthsToPayoffTest()
        {
            //Arrange
            CreditCardPayoffCalculator payoffCalculator = new CreditCardPayoffCalculator()
            {
                APR = 2.5,
                Balance = 25000,
                MonthlyPayment = 2400
            };

            //Act
            double result = payoffCalculator.GetNumberOfMonthsToPayoff();

            //Assert
            Assert.AreEqual(11, result);
        }
    }
}