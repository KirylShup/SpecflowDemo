using OpenQA.Selenium;

namespace SpecFlowProject1.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public string URL => ""; // place your web page here

        public Elements PageElements => new Elements();
        public sealed class Elements
        {
            public string EmailInput => "//input[@name='email']";
            public string PasswordInput => "//input[@name='password']";
            public string LoginButton => "//span[text()='Log In']/parent::button";
        }

        public void NavigateToThePage()
        {
            _driver.Navigate().GoToUrl(URL);
        }
        public void Login(string username, string password)
        {
            _waiter.Until(x => x.FindElement(By.XPath(PageElements.EmailInput)).Displayed);
            _driver.FindElement(By.XPath(PageElements.EmailInput)).SendKeys(username);
            _driver.FindElement(By.XPath(PageElements.PasswordInput)).SendKeys(password);
            _driver.FindElement(By.XPath(PageElements.LoginButton)).Click();
        }
    }
}
