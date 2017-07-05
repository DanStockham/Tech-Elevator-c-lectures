using BoDi;
using FlyByNightBank.UITests.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace FlyByNightBank.UITests.StepDefinitions
{
    [Binding]
    public class CompoundInterestSteps
    {
        private readonly TestingContext context;
        public CompoundInterestSteps(TestingContext context)
        {
            this.context = context;
        }        

        [AfterScenario]
        public void AfterScenario()
        {            
            context.Driver.Quit();
        }

        
        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {            
            context.Driver.Navigate().GoToUrl("http://localhost:63394/");
        }


        [Given(@"I want to calculate compound interest")]
        public void GivenIWantToCalculateCompoundInterest()
        {
            CompoundInterestPage page = new CompoundInterestPage(context.Driver);
            page.Navigate();

            ScenarioContext.Current.Set(page, "Current_Page");
        }

        [When(@"I enter my principal, interest rate, and term")]
        public void WhenIEnterMyPrincipalInterestRateAndTerm()
        {
            CompoundInterestPage page = ScenarioContext.Current.Get<CompoundInterestPage>("Current_Page");

            page.EnterPrincipal(10000);
            page.EnterInterestRate("1.0%");
            page.EnterLoanTerm(LoanYears.ThreeYears);

            CompoundInterestResultPage resultPage = page.SubmitForm();
            ScenarioContext.Current.Set(resultPage, "Current_Page");
        }

        [Then(@"I should see how much money I have saved")]
        public void ThenIShouldSeeHowMuchMoneyIHaveSaved()
        {
            CompoundInterestResultPage page = ScenarioContext.Current.Get<CompoundInterestResultPage>("Current_Page");

            Assert.AreEqual("$10,303.01", page.AmountSaved.Text);
        }

        [When(@"I submit the form without the required data")]
        public void WhenISubmitTheFormWithoutTheRequiredData()
        {
            CompoundInterestPage page = ScenarioContext.Current.Get<CompoundInterestPage>("Current_Page");

            page = page.SubmitFormExpectingFailure();

            ScenarioContext.Current.Set(page, "Current_Page");
        }

        [Then(@"I should see the calculate compound interest page again")]
        public void ThenIShouldSeeTheCalculateCompoundInterestPageAgain()
        {
            CompoundInterestPage page = ScenarioContext.Current.Get<CompoundInterestPage>("Current_Page");
            Assert.IsTrue(context.Driver.Url.EndsWith(page.Url));
        }

    }
}
