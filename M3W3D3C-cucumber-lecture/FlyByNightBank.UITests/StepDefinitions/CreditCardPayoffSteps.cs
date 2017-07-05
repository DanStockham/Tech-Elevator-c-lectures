using FlyByNightBank.UITests.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace FlyByNightBank.UITests.StepDefinitions
{
    [Binding]
    public class CreditCardPayoffSteps
    {
        public readonly TestingContext context;
        public CreditCardPayoffSteps(TestingContext context)
        {
            this.context = context;
        }

        

        [AfterScenario]
        public void AfterScenario()
        {
            this.context.Driver.Quit();
        }

        [Given(@"I want to calculate credit card payoff")]
        public void GivenIWantToCalculateCreditCardPayoff()
        {
            CreditCardPayoffPage payoffPage = new CreditCardPayoffPage(context.Driver);
            payoffPage.Navigate();

            ScenarioContext.Current.Set<CreditCardPayoffPage>(payoffPage, "Current_Page");
        }

        [When(@"I provide my (.*), (.*), and (.*)")]
        public void WhenIProvideMyAnd(double apr, double balance, double monthlyPayment)
        {
            CreditCardPayoffPage currentPage = ScenarioContext.Current.Get<CreditCardPayoffPage>("Current_Page");
            currentPage.EnterAPR(apr)
                .EnterBalance(balance)
                .EnterMonthlyPayment(monthlyPayment);

            ScenarioContext.Current.Set<CreditCardPayoffPage>(currentPage, "Current_Page");
        }


        [When(@"I submit the calculate credit card form")]
        public void WhenISubmitTheCalculateCreditCardForm()
        {
            CreditCardPayoffPage currentPage = ScenarioContext.Current.Get<CreditCardPayoffPage>("Current_Page");

            CreditCardPayoffResultPage resultPage = currentPage.SubmitForm();

            ScenarioContext.Current.Set<CreditCardPayoffResultPage>(resultPage, "Current_Page");

        }

        [Then(@"I should see the payoff page that shows me it takes (.*) to pay off")]
        public void ThenIShouldSeeThePayoffPageThatShowsMeItTakesMonthsToPayOff(string payoff)
        {
            CreditCardPayoffResultPage resultPage = ScenarioContext.Current.Get<CreditCardPayoffResultPage>("Current_Page");
            Assert.AreEqual(payoff, resultPage.PayoffTime.Text);
        }
    }
}
