using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace mibileTest
{
    public class CalendarPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public CalendarPage(AppiumDriver<AndroidElement> driver)
        {
            _driver = driver;
        }

        private readonly By _firstNovemberButton = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget." +
            "LinearLayout[1]/android.widget.LinearLayout[1]/android.view.View[2]");
        private readonly By _removePeriod = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android." +
            "widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.FrameLayout/android.widget.ListView/" +
            "android.widget.TextView[3]");
        private readonly By _previosPage = By.Id("com.popularapp.periodcalendar:id/bt_pre");

        public CalendarPage FirstNovemberButton()
        {
            _driver.FindElement(_firstNovemberButton).Click();
            _driver.FindElement(_firstNovemberButton).Click();
            return this;
        }

        public string RemovePeriodButton()
        {
            return _driver.FindElement(_removePeriod).Text;
        }

        public CalendarPage PreviosPage()
        {
            _driver.FindElement(_previosPage).Click();
            return this;
        }
    }
}