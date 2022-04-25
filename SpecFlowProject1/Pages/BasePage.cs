using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowProject1.Pages
{
    public class BasePage
    {
        private protected IWebDriver _driver;
        private protected WebDriverWait _waiter;

        public BasePage(IWebDriver driver, WebDriverWait waiter)
        {
            _driver = driver;
            _waiter = waiter;
        }

        public bool IsDisplayed(string locator)
        {
            try
            {
                _waiter.Until(x => x.FindElement(By.XPath(locator)) != null && x.FindElement(By.XPath(locator)).Displayed);
            }
            catch (NoSuchElementException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Thread.Sleep(2000);
                _waiter.Until(x => x.FindElement(By.XPath(locator)) != null && x.FindElement(By.XPath(locator)).Displayed);
            }
            return _driver.FindElement(By.XPath(locator)).Displayed;
        }
    }
}
