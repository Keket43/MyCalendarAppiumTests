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
        private MainPage mainPage;
        private SettingPage settingPage;

        public SettingSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            mainPage = new MainPage(_driver);
            settingPage = new SettingPage(_driver);
        }

        [When(@"I tap on setting button")]
        public void WhenITapOnSettingButton()
        {
            mainPage.SettingButton();
        }

        [When(@"I tap on language button")]
        public void WhenITapOnLanguageButton()
        {
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
            Assert.AreEqual("Settings", settingPage.SettingsTitleText());
        }

        [When(@"I tap on Period Length button")]
        public void WhenITapOnPeriodLengthButton()
        {
            settingPage.TapOnPeriodLength();
        }

        [When(@"I tap on Plus icon")]
        public void WhenITapOnIcon()
        {
            settingPage.TapOnPlusIcon();
        }

        [Then(@"Amount of days on screen increments")]
        public void ThenAmountOfDaysOnScreenIncrements()
        {
            Assert.AreEqual("5", settingPage.AmountOfDaysText());
        }

        [When(@"I tap on OK icon")]
        public void WhenITapOnOKIcon()
        {
            settingPage.TapOnOkIcon();
        }

        [Then(@"Settings screen opens with new period length")]
        public void ThenSettingsScreenOpensWithNewPeriodLength()
        {
            Assert.AreEqual("5 days", settingPage.PeriodLengthText());
        }






    }
}