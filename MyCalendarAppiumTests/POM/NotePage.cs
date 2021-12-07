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

        private readonly By _weightText = By.CssSelector("[resource-id=\"com.popularapp.periodcalendar:id/weight_temp\"]");
        private readonly By _dText = By.CssSelector("[resource-id=\"com.popularapp.periodcalendar:id/icon\"]");

        public string WeightResultat()
        {
            Helper.VerticalSwipeFromElementCenter(_dText, _driver, 1, 0.2);
            Helper.Scroll(555, 1633, 555, 541, _driver);
            return _driver.FindElement(_weightText).Text;
        }
    }
}