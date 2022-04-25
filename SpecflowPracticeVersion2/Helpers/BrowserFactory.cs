using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SpecflowPractice.Helpers
{
    public class BrowserFactory
    {
        public enum Browser
        {
            Chrome,
            Firefox,
            Edge
        }
        
        public static IWebDriver Instance()
        {
            Browser browser = Browser.Firefox;
            switch (browser)
            {
                case Browser.Chrome:
                    {
                        var chromeOptions = new ChromeOptions();
                        chromeOptions.AddArgument("start-maximized");
                        return new ChromeDriver(chromeOptions);
                    }
                case Browser.Firefox:
                    {
                        var firefoxOptions = new FirefoxOptions();
                        return new FirefoxDriver(firefoxOptions);
                    }
                case Browser.Edge:
                    {
                        var edgeOptions = new EdgeOptions();
                        return new EdgeDriver(edgeOptions);
                    }
                default: throw new NullReferenceException();
            }
        }

        public static WebDriverWait GetWaiter(IWebDriver driver)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }
    }
}
