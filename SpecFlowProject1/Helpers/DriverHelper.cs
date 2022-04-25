using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowProject1.Helpers
{
    public class DriverHelper
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }
    }
}
