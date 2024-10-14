using System.Configuration;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium.Chrome;
using WebdriverSpecflow.Utils;

namespace WebdriverSpecflow.Hooks
{
    [Binding]
    public sealed class ScenarioHook
    {
        public static ThreadLocal<IWebDriver> ThreadLocalDriver = new ThreadLocal<IWebDriver>();

        [BeforeScenario]
        public void BeforeScenario()
        {
            var browserType = Environment.GetEnvironmentVariable("BROWSER_TYPE");
            ThreadLocalDriver.Value = WebDriverFactory.Create(browserType);
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