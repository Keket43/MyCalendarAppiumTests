using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace mibileTest
{
    public class LogPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public LogPage(AppiumDriver<AndroidElement> driver)
        {
            _driver = driver;
        }

        private readonly By _addPeriodButton = By.Id("com.popularapp.periodcalendar:id/add_layout");
        private readonly By _backInMenuButton = By.Id("com.popularapp.periodcalendar:id/bt_back");
        private readonly By _firstNovember = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.RelativeLayout/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout[1]/android.widget.LinearLayout/android.widget.LinearLayout[1]/android.view.View[2]");
        private readonly By _savePeriodButton = By.Id("com.popularapp.periodcalendar:id/done");
        private readonly By _newNovPeriod = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout" +
            "/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.RelativeLayout[2]/" +
            "android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.LinearLayout[2]/android.widget.LinearLayout[2]" +
            "/android.widget.LinearLayout/android.widget.LinearLayout/android.view.View");


        public LogPage AddPeriodButton()
        {
            _driver.FindElement(_addPeriodButton).Click();
            return this;
        }

        public LogPage FirstNovember()
        {
            Helper.Scroll(727, 333, 727, 1243, _driver);
            Helper.Scroll(727, 435, 727, 606, _driver);
            Helper.Waiter(_driver);
            _driver.FindElement(_firstNovember).Click();
            return this;
        }

        public LogPage SavePeriodButton()
        {
            _driver.FindElement(_savePeriodButton).Click();
            return this;
        }

        public string NewNovemberPeriod()
        {
            return _driver.FindElement(_newNovPeriod).Text;
        }

        public LogPage BackButton()
        {
            _driver.FindElement(_backInMenuButton).Click();
            return this;
        }
    }
}