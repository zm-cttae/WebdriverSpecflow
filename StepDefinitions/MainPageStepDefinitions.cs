using NUnit.Framework;
using WebdriverSpecflow.Pages;
using WebdriverSpecflow.Hooks;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace WebdriverSpecflow.StepDefinitions
{
    [Binding]
    public sealed class MainPageStepDefinitions
    {
        private readonly IWebDriver _driver;
        private readonly MainPage _mainPage;
        private readonly WebDriverWait _wait;

        public MainPageStepDefinitions()
        {
            _driver = ScenarioHook.ThreadLocalDriver.Value;
            _mainPage = new MainPage();
            _wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 5));
        }

        [Given("I went to the mainpage")]
        public void GivenIWentToTheMainPage()
        {
            _driver.Navigate().GoToUrl("https://bstackdemo.com/");
        }

        [When("I click the signin link")]
        public void WhenIClickSigninLink()
        {
            _mainPage.SignInLink.Click();
            _wait.Until(ExpectedConditions.StalenessOf(_mainPage.SignInLink));
        }

        [Then("I am on the mainpage")]
        public void ThenIAmOnTheMainPage()
        {
            Assert.That(_driver.Url, Is.EqualTo("https://bstackdemo.com/?signin=true"));
        }

        [Then("Profile name should appear")]
        public void ThenProfileNameShouldAppear()
        {
            Assert.That(_mainPage.ProfileName.Text, Is.EqualTo("demouser"));
        }
    }
}
