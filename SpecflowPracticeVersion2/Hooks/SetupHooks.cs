using BoDi;
using OpenQA.Selenium;
using SpecflowPractice.Helpers;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    public class SetupHooks
    {
        private readonly IObjectContainer _objectContainer;

        public SetupHooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var webDriver = BrowserFactory.Instance();
            _objectContainer.RegisterInstanceAs<IWebDriver>(webDriver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
           if (_objectContainer != null)
           {
                var webDriver = _objectContainer.Resolve<IWebDriver>();
                webDriver.Quit();
                webDriver.Dispose();
                _objectContainer.Dispose();
           }
        }
    }
}