using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyByNightBank.UITests.PageObjects
{
    /*
    * A Page Object encapsulates the page so that the unit tests
    * do not need to actually know the id's, class names, or element tags
    * on the page.   
    */
    public class CompoundInterestPage : BasePage
    {
        public CompoundInterestPage(IWebDriver driver)
            : base(driver, "/Calculators/CompoundInterest")
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "Principal")]
        public IWebElement Principal { get; set; }

        [FindsBy(How = How.Name, Using = "InterestRate")]
        public IWebElement InterestRate { get; set; }

        [FindsBy(How = How.Name, Using = "NumberOfYears")]
        public IWebElement NumberOfYears { get; set; }

        [FindsBy(How = How.CssSelector, Using = "form button")]
        public IWebElement CalculateButton { get; set; }

        public CompoundInterestResultPage FillOutForm(double principal, string interestRate, LoanYears loanTerm)
        {
            // Set the Principal
            Principal.SendKeys(principal.ToString());

            // Set the Drop Down
            SelectElement interestDropDown = new SelectElement(InterestRate);
            interestDropDown.SelectByText(interestRate);

            string id = $"Number_Of_Years_{(int)loanTerm}";
            IWebElement radioButton = driver.FindElement(By.Id(id));
            radioButton.Click();

            CalculateButton.Click();

            return new CompoundInterestResultPage(driver);
        }
    }

    public enum LoanYears
    {
        OneYear = 1,
        ThreeYears = 3,
        FiveYears = 5
    }
}
