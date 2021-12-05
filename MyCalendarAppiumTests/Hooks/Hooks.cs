using OpenQA.Selenium.Appium.Android;
using QuizletUIAppiumTests.Drivers;
using TechTalk.SpecFlow;

namespace QuizletUIAppiumTests
{
    [Binding]
    public sealed class Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            AppiumDriver appiumDriver = new AppiumDriver();
            _scenarioContext.Set(appiumDriver.InitializeAppium(), "driver");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver").Dispose();
        }
    }
}