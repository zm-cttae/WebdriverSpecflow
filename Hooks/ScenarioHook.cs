using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace WebdriverSpecflow.Hooks
{
    [Binding]
    public sealed class ScenarioHook
    {
        public static ThreadLocal<IWebDriver> ThreadLocalDriver = new ThreadLocal<IWebDriver>();

        [BeforeScenario]
        public void BeforeScenario()
        {
            ThreadLocalDriver.Value = new ChromeDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (ThreadLocalDriver.IsValueCreated)
            {
                ThreadLocalDriver.Value?.Quit();
            }
        }
    }
}