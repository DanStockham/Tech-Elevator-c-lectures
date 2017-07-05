using FlyByNightBank.UITests.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyByNightBank.UITests.SeleniumTests
{
    [TestClass]
    public class CalculatorTests
    {
        private static IWebDriver driver;

        [ClassInitialize]
        public static void SetUp(TestContext context)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:63394/");
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void SubmitCompoundInterestModel_WithValidData_GoToResultPage()
        {
            CompoundInterestPage entryPage = new CompoundInterestPage(driver);
            entryPage.Navigate();

            CompoundInterestResultPage resultPage = entryPage.FillOutForm(10000.00, "1.0%", LoanYears.ThreeYears);

            Assert.AreEqual("$10,000.00", resultPage.Principal.Text);
            Assert.AreEqual("1.0%", resultPage.InterestRate.Text);
            Assert.AreEqual("3 years", resultPage.Term.Text);
            Assert.AreEqual("$10,303.01", resultPage.AmountSaved.Text);
        }
    }
}
