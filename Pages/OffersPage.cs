namespace WebdriverSpecflow.Pages;

public sealed class OffersPage : BasePage
{
    public IWebElement GeolocationParagraph => _driver.FindElement(By.XPath("//*[@id='__next']/main/div/div/div"));
}
