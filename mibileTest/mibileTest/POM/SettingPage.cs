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

        public SettingPage LanguageButton()
        {           
            _driver.FindElement(_languageButton).Click();
            return this;
        }   
        
        public SettingPage RussianButton()
        {           
            _driver.FindElement(_russianButton).Click();
            return this;
        }
    }
}