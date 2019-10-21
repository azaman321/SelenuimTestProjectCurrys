using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumSampleTest.Pages;
using System;
using TechTalk.SpecFlow;

namespace SeleniumSampleTest
{
    [Binding]
    public class SignIntoCurrysSteps
    {
        private IWebDriver driver;
        CurrysHomePage homePage;
        [Scope(Feature = "Sign Into Currys")]
        [BeforeScenario]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homePage = new CurrysHomePage(driver);


        }
     

        [Given(@"I have am on the Currys website")]
        public void GivenIHaveAmOnTheCurrysWebsite()
        {


            homePage.GoToPage();

        }

       

        [When(@"I enter my username and passord")]
        public void WhenIEnterMyUsernameAndPassord()
        {
            homePage.FillinEmailAdress();
            homePage.FillinPassword();
        }

        [When(@"I select the '(.*)' button")]
        public void WhenISelectTheButton(string opt)
        {
            homePage.SelectType();
        }


        [When(@"I click the sign in button")]
        public void WhenIClickTheSignInButton()
        {
            homePage.SignIn();
        }

        [Then(@"the abbreviation of the username should be visible on the dashboard")]
        public void ThenTheAbbreviationOfTheUsernameShouldBeVisibleOnTheDashboard()
        {
            Assert.AreEqual("Hello, A.", homePage.DashboardUser());
        }


        [Scope(Feature = "Sign Into Currys")]
        [AfterScenario]
        public void TearDown()
        {
            driver.Close();
        }
    }
}

