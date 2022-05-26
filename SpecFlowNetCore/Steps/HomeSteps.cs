using OpenQA.Selenium;
using SpecFlowNetCore.Driver;
using SpecFlowNetCore.Pages;
using SpecFlowNetCore.TestData;
using TechTalk.SpecFlow;

namespace SpecFlowNetCore.Steps
{
    [Binding]
    class HomeSteps
    {
        protected TestDetails Data = JsonManager.GetTestData();
        private HomePage homePage = new HomePage();
        public IWebDriver WebDriver => DriverFactory.Driver;

        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            WebDriver.Navigate().GoToUrl(Data.HomePageUrl);
        }

        [Given(@"I click SignIn link")]
        public void GivenIClickSignInLink()
        {
            homePage.ClickSignIn();
        }

        [Then(@"I close the application")]
        public void ThenICloseTheApplication()
        {
            DriverFactory.QuitDriver();
        }
    }
}
