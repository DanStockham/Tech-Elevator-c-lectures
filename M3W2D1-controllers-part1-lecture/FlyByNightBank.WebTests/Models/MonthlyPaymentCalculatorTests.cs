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
    public class MonthlyPaymentCalculatorTests
    {
        [TestMethod()]
        public void GetMonthlyPaymentTest()
        {
            MonthlyPaymentCalculator calculator = new MonthlyPaymentCalculator()
            {
                LoanAmount = 100000,
                InterestRate = 3.92,
                LoanTermInYears = 30
            };

            double result = calculator.GetMonthlyPayment();

            Assert.AreEqual(472.81, result);
        }
    }
}