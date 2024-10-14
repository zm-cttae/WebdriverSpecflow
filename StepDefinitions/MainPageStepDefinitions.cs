using WebdriverSpecflow.Pages;
using WebdriverSpecflow.Hooks;
using WebdriverSpecflow.Utils;
using WebdriverSpecflow.StepData;

namespace WebdriverSpecflow.StepDefinitions;

[Binding]
public sealed class MainPageStepDefinitions
{
    private readonly IWebDriver _driver;
    private readonly MainPage _mainPage;
    private readonly LoginActions _loginActions;

    public MainPageStepDefinitions()
    {
        _driver = ScenarioHook.ThreadLocalDriver.Value;
        _mainPage = new MainPage();
        _loginActions = new LoginActions();
    }

    [Given("I went to the main page")]
    public void GivenIWentToTheMainPage()
    {
        _driver.Navigate().GoToUrl(MainPageStepData.MainUrl);
    }

    [Given("I am not logged in")]
    public void GivenIAmNotLoggedIn()
    {
        Assert.That(_mainPage.SignInLink.Displayed, Is.True);
    }

    [Given("I am logged in as demouser")]
    public void GivenIAmLoggedInAsDemouser()
    {
        _loginActions.clickLoginLink();
        _loginActions.enterDetails();
        _loginActions.clickButton();
    }

    [When("I click the login link")]
    public void WhenIClickLoginLink()
    {
        _loginActions.clickLoginLink();
    }

    [When("I click the Offers link")]
    public void WhenIClickOffersLink()
    {
        _mainPage.OffersLink.Click();
    }

    [Then("I am on the main page")]
    public void ThenIAmOnTheMainPage()
    {
        Uri uri = new Uri(_driver.Url);
        Assert.That(uri.AbsolutePath, Is.EqualTo(MainPageStepData.MainUrlPath), _driver.Url);
    }

    [Then("Profile name should appear")]
    public void ThenProfileNameShouldAppear()
    {
        Assert.That(_mainPage.ProfileName.Text, Is.EqualTo("demouser"));
    }
}
