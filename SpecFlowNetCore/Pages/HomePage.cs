using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using SpecFlowNetCore.Driver;

namespace SpecFlowNetCore.Pages
{
    public class HomePage : BasePage
    {
        private By SignInButton = By.XPath("//div[@class='header_user_info']//a");
        private By LogoButton = By.XPath("//a[@title='My Store']");
        private By AddToCartButton = By.XPath("//li[contains(@class,'product')][1]//a[contains(@class,'cart')]");
        private By ProceedToCheckoutButton = By.XPath("//div[@class='clearfix']//a[@title='Proceed to checkout']");
        private By ProductName = By.XPath("//li[contains(@class,'product')][1]//a[contains(@class,'name')]"); 

        public HomePage()
        {
        }

        public void ClickSignIn()
        {
            WebDriverExtensions.FindElement(Driver,SignInButton, Data.WaitTime).Click();
        }

        public void ClickLogo()
        {
            WebDriverExtensions.FindElement(Driver, LogoButton, Data.WaitTime).Click();
        }

        public void AddProductToCart()
        {
            WebDriverExtensions.FindElement(Driver, AddToCartButton, Data.WaitTime).Click();
        }

        public void GoToCart()
        {
            Driver.GetWait().Until(ExpectedConditions.ElementToBeClickable(ProceedToCheckoutButton)).Click();
        }

        public string GetProductName()
        {
           var productName  =  WebDriverExtensions.FindElement(Driver, ProductName, Data.WaitTime).GetDomAttribute("title");

            return productName;
        }
    }
}
