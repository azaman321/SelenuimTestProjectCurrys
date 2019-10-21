using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumSampleTest.Pages
{
    class CurrysHomePage
    {
        private IWebDriver driver;

        public CurrysHomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='header']/div/div/div/div[3]/a[4]")]
        private IWebElement firstSignIn;

        [FindsBy(How = How.XPath, Using = "//*[@id='input-sEmail']")]
        private IWebElement emailAddress;

        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div[2]/div/div/form/div[1]/div[2]/label/div")]
        private IWebElement selectType;

        [FindsBy(How = How.XPath, Using = "//*[@id='input-sPassword']")]
        private IWebElement password;

        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div[2]/div/div/form/div[3]/button")]
        private IWebElement signIn;

        [FindsBy(How = How.ClassName, Using = "dc-menu-label")]
        private IWebElement dashboardUser;




        public void GoToPage()
        {
            driver.Navigate().GoToUrl("https://www.currys.co.uk/gbuk/s/authentication.html");

        }
        public void FirstSignin()
        {
            firstSignIn.Click();
        }


        public void FillinEmailAdress()
        {
            emailAddress.SendKeys("aazeez@spartaglobal.com");
        }

        public void SelectType()
        {
            selectType.Click();
        }

        public void FillinPassword()
        {
            password.SendKeys("$Uperman5");
        }

        public void SignIn()
        {
            signIn.Click();
        }

        public string DashboardUser()
        {
            return dashboardUser.Text;
        }

    }

}
