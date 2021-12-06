using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using TechTalk.SpecFlow;

namespace MyCalendarAppiumTests
{
    [Binding]
    public class LogPageSteps
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly ScenarioContext _scenarioContext;
        private RegistrationPage registrationPage;
        private LogPage logPage;
        private MainPage mainPage;
        private CalendarPage calendarPage;

        public LogPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            registrationPage = new RegistrationPage(_driver);
            logPage = new LogPage(_driver);
            mainPage = new MainPage(_driver);
            calendarPage = new CalendarPage(_driver);
        }

        [When(@"I click on log button")]
        public void WhenIClickOnLogButton()
        {
            mainPage.LogButton();
        }

        [When(@"I click on add period button")]
        public void WhenIClickOnAddPeriodButton()
        {
            logPage.AddPeriodButton();
        }

        [When(@"I chose first november in period")]
        public void WhenIChoseFirstNovemberInPeriod()
        {
            logPage.FirstNovember();
        }

        [When(@"I save changes")]
        public void WhenISaveChanges()
        {
            logPage.SavePeriodButton();
        }

        [Then(@"i See added new november period '(.*)'")]
        public void ThenISeeAddedNewNovemberPeriod(string textResultat)
        {
            bool checkResultat = logPage.NewNovemberPeriod().Contains(textResultat);
            Console.WriteLine($"log -  {logPage.NewNovemberPeriod()}");
            Assert.IsTrue(checkResultat);
        }

        [When(@"I click on back button in log page")]
        public void WhenIClickOnBackButtonInLogPage()
        {
            logPage.BackButton();
        }

        [When(@"I click on calendar button")]
        public void WhenIClickOnCalendarButton()
        {
            mainPage.CalendarButton();
        }

        [Then(@"I see remove november period")]
        public void ThenISeeRemoveNovemberPeriod()
        {
            calendarPage.FirstNovemberButton();
            Assert.AreEqual("Remove Period", calendarPage.RemovePeriodButton());
        }
    }
}