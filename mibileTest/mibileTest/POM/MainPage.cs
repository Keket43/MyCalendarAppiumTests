using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace mibileTest
{
    public class MainPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public MainPage(AppiumDriver<AndroidElement> driver)
        {
            _driver = driver;
        }

        private readonly By _logButton = By.Id("com.popularapp.periodcalendar:id/bt_go_log_layout");
        private readonly By _calendarButton = By.Id("com.popularapp.periodcalendar:id/bt_go_calendar_layout");
        private readonly By _calendarButtonText = By.Id("com.popularapp.periodcalendar:id/bt_go_calendar");
        private readonly By _settingButton = By.Id("com.popularapp.periodcalendar:id/bt_go_setting_layout");
        private readonly By _chartButton = By.Id("com.popularapp.periodcalendar:id/bt_go_chart_layout");
        private readonly By _noteButton = By.Id("com.popularapp.periodcalendar:id/bt_go_note_layout");

        public MainPage LogButton()
        {           
            _driver.FindElement(_logButton).Click();
            return this;
        }   
        
        public MainPage CalendarButton()
        {           
            _driver.FindElement(_calendarButton).Click();
            return this;
        }

        public string CalendarButtonText()
        {
            return _driver.FindElement(_calendarButtonText).Text;           
        }

        public MainPage SettingButton()
        {
            _driver.FindElement(_settingButton).Click();
            return this;
        }
        
        public MainPage ChartButton()
        {
            _driver.FindElement(_chartButton).Click();
            return this;
        }        
        
        public MainPage NoteButton()
        {
            _driver.FindElement(_noteButton).Click();
            return this;
        }
    }
}