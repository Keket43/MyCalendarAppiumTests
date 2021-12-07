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

       
        [Given(@"I tap on Add Note button")]
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

        [When(@"I save changes")]
        public void WhenISaveChanges()
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


        //  [Then(@"I see a '(.*)' weight in field")]
        //public void ThenISeeAWeightInField(int weightResultat)
        //{
        //    chartPage.BackInMainPage();
        //    mainPage.NoteButton();
        //    bool checkResultat = notePage.WeightResultat().Contains(weightResultat.ToString());
        //    Assert.IsTrue(checkResultat);
        //}



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

        [Then(@"I see chosen sticker near Moods button")]
        public void ThenISeeChosenStickerNearMoodsButton()
        {
            addNotePage.GetChosenMoodSticker();
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

       
        [Then(@"I see chosen sticker near Symptoms button")]
        public void ThenISeeChosenStickerNearSymptomsButton()
        {
           addNotePage.GetChosenSymptomsSticker();
        }


        //5

    }

}

   

