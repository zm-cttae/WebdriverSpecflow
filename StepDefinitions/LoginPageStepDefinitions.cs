using WebdriverSpecflow.Pages;
using WebdriverSpecflow.Hooks;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace WebdriverSpecflow.StepDefinitions
{
    [Binding]
    public sealed class LoginPageStepDefinitions
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage _loginPage;
        private readonly WebDriverWait _wait;

        public LoginPageStepDefinitions()
        {
            _driver = ScenarioHook.ThreadLocalDriver.Value;
            _loginPage = new LoginPage();
            _wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 5));
        }

        [Then("I am on the signin page")]
        public void ThenIAmOnTheSigninPage()
        {
            Assert.That(_driver.Url, Is.EqualTo("https://bstackdemo.com/signin"));
        }

        [When("I enter the login details")]
        public void WhenIEnterTheLoginDetails()
        {
            _loginPage.UsernameSelect.Click();
            _loginPage.UsernameOption.Click();
            _loginPage.PasswordSelect.Click();
            _loginPage.PasswordOption.Click();
        }

        [When("I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            _loginPage.LoginButton.Click();
            _wait.Until(ExpectedConditions.StalenessOf(_loginPage.LoginButton));
        }
    }
}
