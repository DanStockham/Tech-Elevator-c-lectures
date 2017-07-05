using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyByNightBank.UITests.PageObjects
{
    public class CompoundInterestResultPage : BasePage
    {
        public CompoundInterestResultPage(IWebDriver driver)
            : base(driver, "/Calculators/CompoundInterestResult")
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "Principal")]
        public IWebElement Principal { get; set; }

        [FindsBy(How = How.Id, Using = "InterestRate")]
        public IWebElement InterestRate { get; set; }

        [FindsBy(How = How.Id, Using = "Term")]
        public IWebElement Term { get; set; }

        [FindsBy(How = How.Id, Using = "AmountSaved")]
        public IWebElement AmountSaved { get; set; }

    }
}
