using NUnit.Framework;
using SpecFlowNetCore.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowNetCore.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        public LoginPage loginPage = new LoginPage();

        [Given(@"I enter the folowing details")]
        public void GivenIEnterTheFolowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            loginPage.Login((string)data.EmailAddress, (string)data.Password);
        }

        [Given(@"I click login button")]
        public void GivenIClickLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then(@"I should see My Account link")]
        public void ThenIShouldSeeMyAccountLink()
        {
            Assert.That(loginPage.IsMyAccountExist(), Is.True);
        }

        [Then(@"I should not see My Account link")]
        public void ThenIShouldNotSeeMyAccountLink()
        {
            Assert.That(loginPage.IsErorrExist(), Is.True);
        }
    }
}
