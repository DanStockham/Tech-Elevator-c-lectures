using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyByNightBank.UITests.PageObjects
{
    public class CreditCardPayoffPage : BasePage        
    {

        public CreditCardPayoffPage(IWebDriver driver)
            : base(driver, "/Calculators/TimeToPayOff")
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "APR")]
        public IWebElement APR { get; set; }

        [FindsBy(How = How.Id, Using = "Balance")]
        public IWebElement Balance { get; set; }

        [FindsBy(How = How.Id, Using = "MonthlyPayment")]
        public IWebElement MonthlyPayment { get; set; }

        [FindsBy(How = How.CssSelector, Using = "form button")]
        public IWebElement Button { get; set; }

        public CreditCardPayoffPage EnterAPR(double apr)
        {            
            APR.SendKeys(apr.ToString());
            return this;
        }

        public CreditCardPayoffPage EnterBalance(double balance)
        {
            Balance.SendKeys(balance.ToString());
            return this;
        }

        public CreditCardPayoffPage EnterMonthlyPayment(double monthlyPayment)
        {
            MonthlyPayment.SendKeys(monthlyPayment.ToString());
            return this;
        }

        public CreditCardPayoffResultPage SubmitForm()
        {
            Button.Click();

            return new CreditCardPayoffResultPage(driver);
        }

        public CreditCardPayoffPage SubmitFormExpectingFailure()
        {
            Button.Click();

            return new CreditCardPayoffPage(driver);
        }
    }
}
