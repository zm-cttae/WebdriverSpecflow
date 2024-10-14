namespace WebdriverSpecflow.Pages;

public sealed class MainPage : BasePage
{
    public IWebElement SignInLink => _driver.FindElement(By.LinkText("Sign In"));
    public IWebElement OffersLink => _driver.FindElement(By.Id("offers"));
    public IWebElement ProfileName => _driver.FindElement(By.ClassName("username"));
}
