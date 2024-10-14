using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using WebdriverSpecflow.Hooks;
using WebdriverSpecflow.Pages;

namespace WebdriverSpecflow.Utils
{
    public sealed class LoginActions
    {
        private readonly IWebDriver _driver;
        private readonly MainPage _mainPage;
        private readonly LoginPage _loginPage;
        private readonly WebDriverWait _wait;

        public LoginActions() {
            _driver = ScenarioHook.ThreadLocalDriver.Value;
            _mainPage = new MainPage();
            _loginPage = new LoginPage();
            _wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 5));
        }

        public void clickLoginLink()
        {
            _mainPage.SignInLink.Click();
            _wait.Until(ExpectedConditions.ElementExists(_loginPage.LoginWrapperBy));
        }
        public void enterDetails()
        {
            _loginPage.UsernameSelect.Click();
            _loginPage.UsernameOption.Click();
            _loginPage.PasswordSelect.Click();
            _loginPage.PasswordOption.Click();
        }
        public void clickButton()
        {
            var btn = _loginPage.LoginButton;
            btn.Click();
            _wait.Until(ExpectedConditions.StalenessOf(btn));
        }
    }
}
