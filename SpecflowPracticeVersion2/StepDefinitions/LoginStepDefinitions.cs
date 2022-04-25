using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProject1.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private LoginPage _loginPage;
        private UsersPage _usersPage;
        private IWebDriver _driver;

        public LoginStepDefinitions(IWebDriver driver)
        {
            _driver = driver;
            _loginPage = new LoginPage(_driver);
            _usersPage = new UsersPage(_driver);
        }

        [Given(@"I navigate to SSP login page")]
        public void GivenINavigateToSSPLoginPage()
        {
            _loginPage.NavigateToThePage();
        }

        [When(@"I login with username and password")]
        public void WhenILoginWithUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _loginPage.Login($"{data.Username}", $"{data.Password}");
        }

        [Then(@"'([^']*)' button should be visible")]
        public void ThenButtonShouldBeVisible(string inviteNewUser)
        {
            var result = _usersPage.IsDisplayed(_usersPage.PageElements.InviteNewUserButton);
            Assert.IsTrue(result);
        }
    }
}
