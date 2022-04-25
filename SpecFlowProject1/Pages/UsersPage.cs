using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowProject1.Pages
{
    public class UsersPage : BasePage
    {
        public UsersPage(IWebDriver driver, WebDriverWait waiter) : base(driver, waiter)
        {
            _driver = driver;
            _waiter = waiter;
        }

        public Elements PageElements => new Elements();
        public sealed class Elements
        {
            public string InviteNewUserButton => "//button[@id='Users-InviteButton']";
        }
    }
}
