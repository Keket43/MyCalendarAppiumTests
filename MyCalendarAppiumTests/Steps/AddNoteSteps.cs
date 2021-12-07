using MyCalendarAppiumTests.POM;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace MyCalendarAppiumTests.Steps
{
    [Binding]
    public class AddNoteSteps
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly ScenarioContext _scenarioContext; 
        private AddNotePage addNotePage;

        public AddNoteSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");            
            addNotePage = new AddNotePage(_driver);
        }

       
        [When(@"I tap on Add Note button")]
        public void WhenITapOnAddNoteButton()
        {
           addNotePage.AddNoteButton();
        }

        [When(@"I tap on create Note button")]
        public void WhenITapOnCreateNoteButton()
        {
            addNotePage.CreateNoteButton();
        }
      
        [When(@"I enter '(.*)' in a field")]
        public void WhenIEnterInAField(string text)
        {
            addNotePage.EnterTextInNoteField(text);
        }

        [When(@"I save changes on creating Note page")]
        public void WhenISaveChangesOnCreatingNotePage()
        {
            addNotePage.SaveButton();
        }
               
        [Then(@"I see my new note '(.*)' near create Note button")]
        public void ThenISeeMyNewNoteNearCreateNoteButton(string textResult)
        {
            addNotePage.GetNoteText();
            bool checkResult = addNotePage.GetNoteText().Contains(textResult.ToString());
            Assert.IsTrue(checkResult);
        }


        //  2 scenar

        [When(@"I enter '(.*)' in a field instead of previous text")]
        public void WhenIEnterInAFieldInsteadOfPreviousText(string text)
        {
            addNotePage.EnterTextInNoteField(text);
        }

        //3

        [When(@"I tap on Moods button")]
        public void WhenITapOnMoodsButton()
        {
            addNotePage.MoodsButton();
        }

        [When(@"I select angelic sticker")]
        public void WhenISelectAngelicSticker()
        {
            addNotePage.SelectAngelicSticker();
        }

        [When(@"I save changes on mood stickers page")]
        public void WhenISaveChangesOnMoodStickersPage()
        {
            addNotePage.SaveMoodButton();
        }

        
        [Then(@"I see chosen sticker near Moods button")]
        public void ThenISeeChosenStickerNearMoodsButton()
        {
            Assert.IsTrue(addNotePage.GetChosenMoodSticker());
        }
      
        //4

        [When(@"I tap on Symptoms button")]
        public void WhenITapOnSymptomsButton()
        {
           addNotePage.SymptomsButton();
        }

        [When(@"I select Dizziness sticker")]
        public void WhenISelectDizzinessSticker()
        {
            addNotePage.DizzinessTwoStarsSticker();
        }
        [When(@"I save changes on symptoms stickers page")]
        public void WhenISaveChangesOnSymptomsStickersPage()
        {
          addNotePage.SaveSymptomsButton();
        }

        [Then(@"I see chosen sticker near Symptoms button")]
        public void ThenISeeChosenStickerNearSymptomsButton()
        {
            Assert.IsTrue(addNotePage.GetChosenSymptomsSticker());
        }


        //5

        [When(@"I save changes on Add Note page")]
        public void WhenISaveChangesOnAddNotePage()
        {
            addNotePage.AddNoteSaveChanges();
        }

        [When(@"I tap on Calendar button")]
        public void WhenITapOnCalendarButton()
        {
           addNotePage.CalendarButton();
        }

        
        [Then(@"I see ""(.*)"" notes at the calendar page")]
        public void ThenISeeNotesAtTheCalendarPage(string text)
        {
            Assert.AreEqual(text, addNotePage.GetNotesAtCalendarPage());
        }

        [Then(@"I see ""(.*)"" at the calendar page")]
        public void ThenISeeAtTheCalendarPage(string text)
        {
            Assert.AreEqual(text, addNotePage.GetMoodsAtCalendarPage());
        }
    }
}

   

