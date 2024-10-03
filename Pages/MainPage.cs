namespace WebdriverSpecflow.Pages
{
    public class MainPage
    {
        private readonly IWebDriver _driver;

        public MainPage()
        {
            _driver = Hooks.ScenarioHook.ThreadLocalDriver.Value;
        }

        public IWebElement SignInLink => _driver.FindElement(By.LinkText("Sign In"));
        public IWebElement ProfileName => _driver.FindElement(By.ClassName("username"));
    }
}
