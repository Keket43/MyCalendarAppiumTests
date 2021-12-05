using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace mibileTest.Steps
{
    [Binding]
    public class SettingSteps
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly ScenarioContext _scenarioContext;
        private RegistrationPage registrationPage;
        private LogPage logPage;
        private MainPage mainPage;
        private CalendarPage calendarPage;
        private SettingPage settingPage;
        private ChartPage chartPage;

        public SettingSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            registrationPage = new RegistrationPage(_driver);
            logPage = new LogPage(_driver);
            mainPage = new MainPage(_driver);
            calendarPage = new CalendarPage(_driver);
            settingPage = new SettingPage(_driver);
            chartPage = new ChartPage(_driver);
        }

        [When(@"I click on setting button")]
        public void WhenIClickOnSettingButton()
        {
            mainPage.SettingButton();
        }

        [When(@"I click on language button")]
        public void WhenIClickOnLanguageButton()
        {
            Helper.Scroll(651,1644,651,261,_driver);
            Helper.Scroll(651,1644,651,261,_driver);
            Helper.Scroll(783,1066,783,575,_driver);
            settingPage.LanguageButton();
        }

        [When(@"i click on Russian language")]
        public void WhenIClickOnRussianLanguage()
        {
            settingPage.RussianButton();
        }

        [Then(@"I see a '(.*)' button")]
        public void ThenISeeAButton(string textResultat)
        {
            Assert.AreEqual(textResultat, mainPage.CalendarButtonText());
        }
    }
}