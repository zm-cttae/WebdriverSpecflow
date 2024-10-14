using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace WebdriverSpecflow.Utils;

public static class WebDriverFactory
{
    public static IWebDriver Create(string type)
    {
        IWebDriver driver = null;
        switch (type)
        {
            case "Firefox":
                driver = new FirefoxDriver();
                break;
            case "Chrome":
                driver = new ChromeDriver();
                break;
            default:
                throw new Exception("No driver configured");
        }
        return driver;
    }
}
