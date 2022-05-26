using OpenQA.Selenium;
using SpecFlowNetCore.Driver;
using SpecFlowNetCore.TestData;

namespace SpecFlowNetCore.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver;
        public TestDetails Data = JsonManager.GetTestData();

        public BasePage()
        {
            DriverFactory.InitalizerDriver();
            Driver = DriverFactory.Driver;
        }
    }
}
