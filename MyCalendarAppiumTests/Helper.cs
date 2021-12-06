using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;
using System;

namespace MyCalendarAppiumTests
{
    public static class Helper
    {
        public static void Scroll(int fromX, int fromY, int toX, int toY, AppiumDriver<AndroidElement> _driver)//pressX, bottomY, pressX, topY
        {
            TouchAction touchAction = new TouchAction(_driver);
            touchAction.LongPress(fromX, fromY).MoveTo(toX, toY).Release().Perform();
        }

        public static void ClickToRemoveKeyboard(int fromX, int fromY, AppiumDriver<AndroidElement> _driver)
        {
            TouchAction touchAction = new TouchAction(_driver);
            touchAction.Press(fromX, fromY).Release().Perform();
        }

        public static void Waiter(AppiumDriver<AndroidElement> _driver)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
        }
    }
}