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
        private string _selectedProductName;
        protected TestDetails Data = JsonManager.GetTestData();
        public HomePage homePage = new HomePage();
        public CartPage cartPage = new CartPage();
        public IWebDriver WebDriver => DriverFactory.Driver;

        [Given(@"I click on logo")]
        public void GivenIClickOnLogo()
        {
            homePage.ClickLogo();
        }

        [Given(@"I click the add to cart button")]
        public void GivenIClickTheAddToCartButton()
        {
            _selectedProductName = homePage.GetProductName();
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
            Assert.AreEqual(_selectedProductName, cartPage.GetProductNameInCart());
        }
    }
}
