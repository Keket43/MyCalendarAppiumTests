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
        private MainPage mainPage;
        private ChartPage chartPage;
        private NotePage notePage;

        public ChartSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            mainPage = new MainPage(_driver);
            chartPage = new ChartPage(_driver);
            notePage = new NotePage(_driver);
        }


        [When(@"I tap on chart button")]
        public void WhenITapOnChartButton()
        {
            mainPage.ChartButton();
        }

        [When(@"I tap on add button")]
        public void WhenITapOnAddButton()
        {
            chartPage.AddCharackter();
        }

        [When(@"I tap on change weight '(.*)'")]
        public void WhenITapOnChangeWeight(int weight)
        {
            chartPage.WeightChangeField()
                .WeightChangeKg().
                WeightField("58");
        }

        [When(@"I tap on change height '(.*)'")]
        public void WhenITapOnChangeHeight(int height)
        {
            chartPage.HeightChangeField()
                .HeightChangeSm()
                .HeightField("165");
        }

        [When(@"I tap on change save")]
        public void WhenITapOnChangeSave()
        {
            chartPage.SaveChanges();
        }

        [Then(@"I see a '(.*)' weight in field")]
        public void ThenISeeAWeightInField(int weightResultat)
        {
            chartPage.BackInMainPage();
            mainPage.NoteButton();
            bool checkResultat = notePage.WeightResultat().Contains(weightResultat.ToString());
            Assert.IsTrue(checkResultat);
        }
    }
}