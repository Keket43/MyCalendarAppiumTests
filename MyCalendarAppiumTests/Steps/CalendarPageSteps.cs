using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace mibileTest.Steps
{
    [Binding]
    public class CalendarPageSteps
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly ScenarioContext _scenarioContext;
        private RegistrationPage registrationPage;
        private LogPage logPage;
        private MainPage mainPage;
        private CalendarPage calendarPage;

        public CalendarPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            registrationPage = new RegistrationPage(_driver);
            logPage = new LogPage(_driver);
            mainPage = new MainPage(_driver);
            calendarPage = new CalendarPage(_driver);
        }

        [When(@"I tap on previos button")]
        public void WhenITapOnPreviosButton()
        {
            calendarPage.PreviosPage();
        }

        [Then(@"I see calendar button '(.*)'")]
        public void ThenISeeCalendarButton(string textResultar)
        {
            Assert.AreEqual(textResultar, mainPage.CalendarButtonText());
        }
    }
}