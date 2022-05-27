using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using SpecFlowNetCore.Driver;

namespace SpecFlowNetCore.Pages
{
    public class HomePage : BasePage
    {
        private By _signInButton = By.XPath("//div[@class='header_user_info']//a");
        private By _logoButton = By.XPath("//a[@title='My Store']");
        private By _addToCartButton = By.XPath("//li[contains(@class,'product')][1]//a[contains(@class,'cart')]");
        private By _proceedToCheckoutButton = By.XPath("//div[@class='clearfix']//a[@title='Proceed to checkout']");
        private By _productName = By.XPath("//li[contains(@class,'product')][1]//a[contains(@class,'name')]"); 

        public HomePage()
        {
        }

        public void ClickSignIn()
        {
            WebDriverExtensions.FindElement(Driver,_signInButton, Data.WaitTime).Click();
        }

        public void ClickLogo()
        {
            WebDriverExtensions.FindElement(Driver, _logoButton, Data.WaitTime).Click();
        }

        public void AddProductToCart()
        {
            WebDriverExtensions.FindElement(Driver, _addToCartButton, Data.WaitTime).Click();
        }

        public void GoToCart()
        {
            Driver.GetWait().Until(ExpectedConditions.ElementToBeClickable(_proceedToCheckoutButton)).Click();
        }

        public string GetProductName()
        {
            var productName  =  WebDriverExtensions.FindElement(Driver, _productName, Data.WaitTime).GetDomAttribute("title");

            return productName;
        }
    }
}
