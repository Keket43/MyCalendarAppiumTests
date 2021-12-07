using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace mibileTest
{
    public class SettingPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public SettingPage(AppiumDriver<AndroidElement> driver)
        {
            _driver = driver;
        }

        private readonly By _languageButton = By.Id("com.popularapp.periodcalendar:id/tv_key_detail");
        private readonly By _russianButton = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android." +
            "widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.FrameLayout/android.widget.ListView" +
            "/android.widget.CheckedTextView[12]");
        private readonly By _settingsTitle = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.widget.TextView");
        private readonly By _sizeFirstBlock = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.ListView/android.widget.LinearLayout[1]/android.widget.RelativeLayout[2]/android.widget.LinearLayout");
        private readonly By _periodLengthButton = By.CssSelector("[resource-id=\"com.popularapp.periodcalendar:id/rl_item\"]");
        private readonly By _plusIcon = By.Id("com.popularapp.periodcalendar:id/data_up");
        private readonly By _amountOfDays = By.Id("com.popularapp.periodcalendar:id/data");
        private readonly By _okIcon = By.Id("com.popularapp.periodcalendar:id/menu_done");
        private readonly By _periodLengthText = By.CssSelector("[resource-id=\"com.popularapp.periodcalendar:id/tv_value\"]");
        private readonly By _pregnancyMenuItem = By.CssSelector("[resource-id=\"com.popularapp.periodcalendar:id/rl_item\"]");
        private readonly By _imPregnantToggle = By.CssSelector("[resource-id=\"com.popularapp.periodcalendar:id / title_layout\"]");
        private readonly By _continueButton = By.Id("android:id/button1");
        private readonly By _backArrowIcon = By.Id("android.widget.ImageButton[@content-desc=\"Navigate up\"]");

        public SettingPage LanguageButton()
        {
            Helper.VerticalSwipeFromElementCenter(_sizeFirstBlock, _driver, 5, 0.9);
            _driver.FindElement(_languageButton).Click();
            return this;
        }

        public SettingPage RussianButton()
        {
            _driver.FindElement(_russianButton).Click();
            return this;
        }

        public string SettingsTitleText()
        {
            return _driver.FindElement(_settingsTitle).Text;
        }

        public SettingPage TapOnPeriodLength()
        {
            _driver.FindElement(_periodLengthButton).Click();
            return this;
        }

        public SettingPage TapOnPlusIcon()
        {
            _driver.FindElement(_plusIcon).Click();
            return this;
        }

        public string AmountOfDaysText()
        {
            return _driver.FindElement(_amountOfDays).Text;
        }

        public SettingPage TapOnOkIcon()
        {
            _driver.FindElement(_okIcon).Click();
            return this;
        }

        public string PeriodLengthText()
        {
            return _driver.FindElement(_periodLengthText).Text;
        }

        public SettingPage TapOnPregnancyMenuItem()
        {
            _driver.FindElement(_pregnancyMenuItem).Click();
            return this;
        }

        public SettingPage TapOnImPregnantToggle()
        {
            _driver.FindElement(_imPregnantToggle).Click();
            return this;
        }

        public SettingPage TapOnContinueButton()
        {
            _driver.FindElement(_continueButton).Click();
            return this;
        }

        public SettingPage TapOnBackArrowIcon()
        {
            _driver.FindElement(_backArrowIcon).Click();
            return this;
        }



    }
}