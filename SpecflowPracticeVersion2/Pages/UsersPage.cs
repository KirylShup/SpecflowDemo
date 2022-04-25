using OpenQA.Selenium;

namespace SpecFlowProject1.Pages
{
    public class UsersPage : BasePage
    {
        public UsersPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public Elements PageElements => new Elements();
        public sealed class Elements
        {
            public string InviteNewUserButton => "//button[@id='Users-InviteButton']";
        }
    }
}
