using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppiumSpecFlowProject1.Utilities;

namespace AppiumSpecFlowProject1.Hooks
{
    [Binding]
    public class TestInitialize :Base
    {
        [BeforeScenario]
        public void TestInitializeTest()
        {
            AndroidContext = StartAppiumServerForHybrid();
            ScenarioContext.Current["androidContext"] = AndroidContext;
        }
        [AfterScenario]
        public void CleanUp()
        {
            AppiumUtilities.CloseAppiumServer();
        }
    }
}
