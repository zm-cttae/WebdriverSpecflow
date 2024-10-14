using OpenQA.Selenium.Support.UI;
using WebdriverSpecflow.Pages;
using WebdriverSpecflow.Hooks;
using WebdriverSpecflow.Utils;
using WebdriverSpecflow.StepData;

namespace WebdriverSpecflow.StepDefinitions
{
    [Binding]
    public sealed class LoginPageStepDefinitions
    {
        private readonly IWebDriver _driver;
        private readonly LoginActions _loginActions;
        private readonly LoginPage _loginPage;
        private readonly WebDriverWait _wait;

        public LoginPageStepDefinitions()
        {
            _driver = ScenarioHook.ThreadLocalDriver.Value;
            _loginActions = new LoginActions();
            _loginPage = new LoginPage();
            _wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 5));
        }

        [Then("I am on the login page")]
        public void ThenIAmOnTheLoginPage()
        {
            Uri uri = new Uri(_driver.Url);
            Assert.That(uri.AbsolutePath, Is.EqualTo(LoginPageStepData.LoginUrlPath), _driver.Url);
        }

        [When("I enter the login details")]
        public void WhenIEnterTheLoginDetails()
        {
            _loginActions.enterDetails();
        }

        [When("I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            _loginActions.clickButton();
        }
    }
}
