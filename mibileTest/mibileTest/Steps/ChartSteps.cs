using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace mibileTest.Steps
{
    [Binding]
    public class ChartSteps
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly ScenarioContext _scenarioContext;
        private RegistrationPage registrationPage;
        private LogPage logPage;
        private MainPage mainPage;
        private CalendarPage calendarPage;
        private ChartPage chartPage;
        private NotePage notePage;

        public ChartSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            registrationPage = new RegistrationPage(_driver);
            logPage = new LogPage(_driver);
            mainPage = new MainPage(_driver);
            calendarPage = new CalendarPage(_driver);
            chartPage = new ChartPage(_driver);
            notePage = new NotePage(_driver);
        }


        [When(@"I click on chart button")]
        public void WhenIClickOnChartButton()
        {
            mainPage.ChartButton();
        }

        [When(@"I click on add button")]
        public void WhenIClickOnAddButton()
        {
            chartPage.AddCharackter();
        }

        [When(@"i click on change weight '(.*)'")]
        public void WhenIClickOnChangeWeight(int weight)
        {
            chartPage.WeightChangeField()
                .WeightChangeKg().
                WeightField("58");
        }

        [When(@"i click on change height '(.*)'")]
        public void WhenIClickOnChangeHeight(int height)
        {
            chartPage.HeightChangeField()
                .HeightChangeSm()
                .HeightField("165");
        }

        [When(@"i click on change save")]
        public void WhenIClickOnChangeSave()
        {
            chartPage.SaveChanges();
        }

        [Then(@"I see a '(.*)' weight in field")]
        public void ThenISeeAWeightInField(int weightResultat)
        {
            Helper.Waiter(_driver);
            chartPage.BackInMainPage();
            mainPage.NoteButton();
            bool checkResultat = notePage.WeightResultat().Contains(weightResultat.ToString());
            Assert.IsTrue(checkResultat);
        }
    }
}