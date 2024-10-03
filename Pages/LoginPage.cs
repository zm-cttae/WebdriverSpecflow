namespace WebdriverSpecflow.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        public LoginPage()
        {
            _driver = Hooks.ScenarioHook.ThreadLocalDriver.Value;
        }

        public IWebElement UsernameSelect => _driver.FindElement(By.Id("username"));
        public IWebElement UsernameOption => _driver.FindElement(By.XPath("//*[@id='react-select-2-option-0-0']"));
        public IWebElement PasswordSelect => _driver.FindElement(By.Id("password"));
        public IWebElement PasswordOption => _driver.FindElement(By.XPath("//*[@id='react-select-3-option-0-0']"));
        public IWebElement LoginButton => _driver.FindElement(By.Id("login-btn"));
    }
}
