using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;


namespace MyCalendarAppiumTests.POM
{

    public class AddNotePage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public AddNotePage(AppiumDriver<AndroidElement> driver)
        {
            _driver = driver;
        }


        private readonly By _addNoteButton = By.Id("com.popularapp.periodcalendar:id/bt_go_note");
        

        //private readonly By _noteButton = By.Id("com.popularapp.periodcalendar:id/bt_go_note_layout");

        private readonly By _createNoteButton = By.XPath("/ hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.RelativeLayout[2]/android.widget.ScrollView/android." +
            "widget.LinearLayout/android.widget.RelativeLayout[4]/android.widget.RelativeLayout");




        private readonly By _enterTextField = By.Id("com.popularapp.periodcalendar:id/note");

        private readonly By _saveNoteButton = By.Id("com.popularapp.periodcalendar:id/bt_right");

        private readonly By _noteText = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.RelativeLayout[2]/android.widget." +
            "ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout[4]/android.widget.RelativeLayout/android.widget.TextView[2]");


        private readonly By _moodsButton = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.RelativeLayout[2]/android.widget.ScrollView/android." +
            "widget.LinearLayout/android.widget.RelativeLayout[8]/android.widget.RelativeLayout");
        private readonly By _saveMoodButton = By.Id("com.popularapp.periodcalendar:id/menu_done");
        private readonly By _angelicSticker = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view." +
            "ViewGroup/android.widget.FrameLayout[2]/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.LinearLayout/android.widget.LinearLayout/androidx." +
            "recyclerview.widget.RecyclerView/android.widget.LinearLayout[3]/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout[2]");
        private readonly By _chosenMoodSticker = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.RelativeLayout[2]/android.widget.ScrollView/android." +
            "widget.LinearLayout/android.widget.RelativeLayout[8]/android.widget.RelativeLayout");


        private readonly By _symptomsButton = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.RelativeLayout[2]/android.widget.ScrollView/android." +
            "widget.LinearLayout/android.widget.RelativeLayout[7]/android.widget.RelativeLayout");
        private readonly By _dizzinessStickerTwoStars = By.Id("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android." +
            "widget.FrameLayout[2]/android.widget.FrameLayout/android.widget.RelativeLayout/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout[10]/android.widget." +
            "LinearLayout/android.widget.RelativeLayout/android.widget.LinearLayout/android.widget.ImageView[2]");
        //save button  com.popularapp.periodcalendar:id/menu_done

        private readonly By _chosenSymptomsSticker = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.RelativeLayout[2]/android.widget.ScrollView/android." +
            "widget.LinearLayout/android.widget.RelativeLayout[7]/android.widget.RelativeLayout/android.widget.LinearLayout/android.widget.ImageView");



        public AddNotePage AddNoteButton()
        {
            _driver.FindElement(_addNoteButton).Click();
            return this;
        }

        public AddNotePage CreateNoteButton()
        {
            _driver.FindElement(_createNoteButton).Click();
            return this;
        }
        public AddNotePage EnterTextInNoteField(string text)
        {
            _driver.FindElement(_enterTextField).SendKeys(text);
            return this;
        }
              
        public AddNotePage SaveButton()
        {
            _driver.FindElement(_saveNoteButton).Click();
            return this;
        }
        public string GetNoteText()
        {
            return _driver.FindElement(_noteText).Text;                     
        }


        
        public AddNotePage MoodsButton()
        {
            _driver.FindElement(_moodsButton).Click();
            return this;
        }
        public AddNotePage SelectAngelicSticker()
        {
            _driver.FindElement(_angelicSticker).Click();
            return this;
        }
        public AddNotePage SaveMoodButton()
        {
            _driver.FindElement(_saveMoodButton).Click();
            return this;
        }
        public AddNotePage GetChosenMoodSticker()
        {
            _driver.FindElement(_chosenMoodSticker).Click();
            return this;
        }


        public AddNotePage SymptomsButton()
        {
            _driver.FindElement(_symptomsButton).Click();
            return this;
        }
        public AddNotePage DizzinessTwoStarsSticker()
        {
            _driver.FindElement(_dizzinessStickerTwoStars).Click();
            return this;
        }
        public AddNotePage GetChosenSymptomsSticker()
        {
            _driver.FindElement(_chosenSymptomsSticker).Click();
            return this;
        }
    }
}
