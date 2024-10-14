namespace WebdriverSpecflow.Pages;

public class BasePage
{
    public readonly IWebDriver _driver;

    public BasePage()
    {
        _driver = Hooks.ScenarioHook.ThreadLocalDriver.Value;
    }
}
