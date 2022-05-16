using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowNetCore.Driver;
using SpecFlowNetCore.Pages;
using SpecFlowNetCore.TestData;
using TechTalk.SpecFlow;

namespace SpecFlowNetCore
{
    [Binding]
    public class AddToCartSteps
    {
        private string selectedProductName;
        protected TestDetails Data = JsonManager.GetTestData();
        internal HomePage homePage = new HomePage();
        internal CartPage cartPage = new CartPage();
        public IWebDriver WebDriver => DriverFactory.Driver;

        [Given(@"I click on logo")]
        public void GivenIClickOnLogo()
        {
            homePage.ClickLogo();
        }

        [Given(@"I click the add to cart button")]
        public void GivenIClickTheAddToCartButton()
        {
            selectedProductName = homePage.GetProductName();
            homePage.AddProductToCart();
        }

        [Given(@"I click Proceed to checkout button")]
        public void GivenIClickProceedToCheckoutButton()
        {
            homePage.GoToCart();
        }

        [Then(@"I should see product in the cart")]
        public void ThenIShouldSeeProductInTheCart()
        {
            Assert.AreEqual(selectedProductName, cartPage.GetProductNameInCart());
        }
    }
}
