using NUnit.Framework;
using SpecFlowProject1.Helpers;
using SpecFlowProject1.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private DriverHelper _driverHelper;
        private LoginPage _loginPage;
        private UsersPage _usersPage;

        public LoginStepDefinitions(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            _loginPage = new LoginPage(_driverHelper.Driver, _driverHelper.Wait);
            _usersPage = new UsersPage(_driverHelper.Driver, _driverHelper.Wait);
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
