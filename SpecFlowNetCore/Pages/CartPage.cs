using OpenQA.Selenium;
using SpecFlowNetCore.Driver;

namespace SpecFlowNetCore.Pages
{
    public class CartPage : BasePage
    {
        private By ProductNameInCart = By.XPath("//td/p[@class='product-name']");

        public CartPage()
        {
        }

        public string GetProductNameInCart()
        {
            var productName = WebDriverExtensions.FindElement(Driver, ProductNameInCart, Data.WaitTime).GetAttribute("textContent");

            return productName;
        }
    }
}
