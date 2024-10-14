using WebdriverSpecflow.Pages;
using WebdriverSpecflow.Hooks;
using WebdriverSpecflow.StepData;

namespace WebdriverSpecflow.StepDefinitions
{
    [Binding]
    public sealed class OffersPageStepDefinitions
    {
        private readonly IWebDriver _driver;
        private readonly OffersPage _offersPage;

        public OffersPageStepDefinitions()
        {
            _driver = ScenarioHook.ThreadLocalDriver.Value;
            _offersPage = new OffersPage();
        }


        [Then("I am on the Offers page")]
        public void ThenIAmOnTheOffersPage()
        {
            Uri uri = new Uri(_driver.Url);
            Assert.That(uri.AbsolutePath, Is.EqualTo(OffersPageStepData.OffersUrlPath), _driver.Url);
        }

        [Then("The geolocation error is visible")]
        public void ThenGeolocationErrorIsVisible()
        {
            Assert.That(_offersPage.GeolocationParagraph.Displayed, Is.True);
        }
    }
}
