using SpecflowPractice.Helpers;
using SpecFlowProject1.Helpers;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    public class SetupHooks
    {
        private DriverHelper _driverHelper;

        public SetupHooks(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driverHelper.Driver = BrowserFactory.Instance();
            _driverHelper.Wait = BrowserFactory.GetWaiter(_driverHelper.Driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverHelper.Driver.Quit();
            _driverHelper.Driver.Dispose();
        }
    }
}