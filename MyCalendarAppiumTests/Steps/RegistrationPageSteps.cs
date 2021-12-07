using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace mibileTest.Steps
{
    [Binding]
    public class RegistrationSteps
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly ScenarioContext _scenarioContext;
        private RegistrationPage registrationPage;

        public RegistrationSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            registrationPage = new RegistrationPage(_driver);
        }

        [When(@"I tap on new user button")]
        public void WhenITapOnNewUserButton()
        {
            registrationPage.NewUser();
        }

        [When(@"I done information in registration field")]
        public void WhenIDoneInformationInRegistrationField()
        {
            registrationPage.DoneStartButton();
        }

        [When(@"I chose first December as a start cycle day")]
        public void WhenIChoseFirstDecemberAsAStartCycleDay()
        {
            registrationPage.FirstDayButton();
        }

        [When(@"I save data")]
        public void WhenISaveData()
        {
            registrationPage.StartSaveButton();
        }

        [When(@"I clear on period field button")]
        public void WhenIClearOnPeriodFieldButton()
        {
            registrationPage.PeriodField();
        }

        [When(@"I clear on cycle field button")]
        public void WhenIClearOnCycleFieldButton()
        {
            registrationPage.CycleField();
        }

        [Then(@"I cant went go over page and i see toast message")]
        public void ThenICantWentGoOverPageAndISeeToastMessage()
        {
            registrationPage.DoneStartButton();
            Assert.AreEqual("The number you entered is invalid!", registrationPage.ToastText());
        }
    }
}