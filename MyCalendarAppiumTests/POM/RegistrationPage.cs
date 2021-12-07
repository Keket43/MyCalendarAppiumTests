using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace mibileTest
{
    public class RegistrationPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public RegistrationPage(AppiumDriver<AndroidElement> driver)
        {
            _driver = driver;
        }
        //[FindsBy(How = How.XPath, Using = "//android.widget.EditText[@content-desc=\"authInputTextTestIDFirst Name\"]")]
        //private AndroidElement loginButton;       

        private readonly By _newUserButton = By.Id("com.popularapp.periodcalendar:id/new_user_text");
        private readonly By _periodField = By.Id("com.popularapp.periodcalendar:id/dialog_edittext_period");
        private readonly By _cycleField = By.Id("com.popularapp.periodcalendar:id/dialog_edittext_cycle");
        private readonly By _doneStartButton = By.Id("com.popularapp.periodcalendar:id/btn_start");
        private readonly By _firstDayButton = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.RelativeLayout/androidx." +
            "recyclerview.widget.RecyclerView/android.widget.LinearLayout[1]/android.widget.LinearLayout/android.widget.LinearLayout[1]/android.view.View[4]");
        private readonly By _saveStartButton = By.Id("com.popularapp.periodcalendar:id/done");

        public RegistrationPage NewUser()
        {
            _driver.FindElement(_newUserButton).Click();
            return this;
        }

        public RegistrationPage DoneStartButton()
        {
            _driver.FindElement(_doneStartButton).Click();
            return this;
        }
        public string DoneStartButtonText()
        {
            return _driver.FindElement(_doneStartButton).Text;
        }

        public RegistrationPage FirstDayButton()
        {
            _driver.FindElement(_firstDayButton).Click();
            return this;
        }

        public RegistrationPage StartSaveButton()
        {
            _driver.FindElement(_saveStartButton).Click();
            return this;
        }

        public RegistrationPage PeriodField()
        {
            _driver.FindElement(_periodField).Clear();
            return this;
        }

        public RegistrationPage CycleField()
        {
            _driver.FindElement(_cycleField).Clear();
            return this;
        }

        public string ToastText()
        {
            return _driver.FindElement(By.XPath("/hierarchy/android.widget.Toast")).Text;
        }
    }
}