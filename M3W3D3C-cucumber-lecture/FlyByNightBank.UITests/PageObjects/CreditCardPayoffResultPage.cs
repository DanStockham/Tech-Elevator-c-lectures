using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyByNightBank.UITests.PageObjects
{
    public class CreditCardPayoffResultPage : BasePage
    {
        public CreditCardPayoffResultPage(IWebDriver driver)
            : base(driver, "/Calculators/TimeToPayOffResult")
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "strong:nth-of-type(4)")]
        public IWebElement PayoffTime { get; set; }        
    }
}