using OpenQA.Selenium;
using SpecFlowNetCore.Driver;

namespace SpecFlowNetCore.Pages
{
    public class HomePage : BasePage
    {
        private By SignInButton = By.XPath("//div[@class='header_user_info']//a");

        public HomePage()
        {
        }

        public void ClickSignIn()
        {
            WebDriverExtensions.FindElement(Driver,SignInButton, Data.WaitTime).Click();
        } 
    }
}
