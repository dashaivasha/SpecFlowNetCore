using OpenQA.Selenium;

namespace SpecFlowNetCore.Pages
{
    public class LoginPage : BasePage
    {
        private IWebElement EmailInput => Driver.FindElement(By.Name("email"));
        private IWebElement PasswordInput => Driver.FindElement(By.Name("passwd"));
        private IWebElement LoginBtn => Driver.FindElement(By.XPath("//button[@id='SubmitLogin']"));
        private IWebElement MyAcounttxt => Driver.FindElement(By.XPath("//h1[text()='My account']"));

        private IWebElement Errortxt => Driver.FindElement(By.XPath("//div[@class='alert alert-danger']//li[text()='Invalid password.']")); 


        public LoginPage()
        {
        }

        public void Login(string email, string password)
        {
            EmailInput.SendKeys(email);
            PasswordInput.SendKeys(password);
        }

        public void ClickLoginButton() => LoginBtn.Submit();

        public bool IsMyAccountExist() => MyAcounttxt.Displayed;

        public bool IsErorrExist() => Errortxt.Displayed;
    }
}
