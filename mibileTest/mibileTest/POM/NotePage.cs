using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace mibileTest
{
    public class NotePage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public NotePage(AppiumDriver<AndroidElement> driver)
        {
            _driver = driver;
        }

        private readonly By _weightText = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android." +
            "widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.RelativeLayout[2]/android." +
            "widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout[6]/android.widget.RelativeLayout/android.widget.TextView[2]");

        public string WeightResultat()
        {
            Helper.Scroll(555, 1633, 555, 541, _driver);
            Helper.Waiter(_driver);
           return _driver.FindElement(_weightText).Text;
        }      
    }
}