using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace MyCalendarAppiumTests
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

        [When(@"I tap on setting button")]
        public void WhenITapOnSettingButton()
        {
            mainPage.SettingButton();
        }

        [When(@"I tap on language button")]
        public void WhenITapOnLanguageButton()
        {
            Helper.Scroll(651, 1644, 651, 261, _driver);
            Helper.Scroll(651, 1644, 651, 261, _driver);
            Helper.Scroll(783, 1066, 783, 575, _driver);
            settingPage.LanguageButton();
        }

        [When(@"I tap on Russian language")]
        public void WhenITapOnRussianLanguage()
        {
            settingPage.RussianButton();
        }

        [Then(@"I see a '(.*)' button")]
        public void ThenISeeAButton(string textResultat)
        {
            Assert.AreEqual(textResultat, mainPage.CalendarButtonText());
        }

        [When(@"I tap on Settings tab on the main screen")]
        public void WhenITapOnSettingsTabOnTheMainScreen()
        {
           mainPage.SettingButton();
        }

        [Then(@"I see Settings screen")]
        public void ThenISeeSettingsScreen()
        {
            Assert.AreEqual("Settings",settingPage.SettingsTitleText());
        }




    }
}