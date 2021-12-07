using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;
using System;

namespace mibileTest
{
    public static class Helper
    {
        public static void Scroll(int fromX, int fromY, int toX, int toY, AppiumDriver<AndroidElement> _driver)//pressX, bottomY, pressX, topY
        {
            TouchAction touchAction = new TouchAction(_driver);
            touchAction.LongPress(fromX, fromY).Wait(1000).MoveTo(toX, toY).Wait(1000).Release().Perform();
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

        public static void VerticalSwipeFromElementCenter(By element, AppiumDriver<AndroidElement> _driver, int count, double sizeOfElement)
        //коефициэнт количества элементов которые влазят в экран, счет идет по размеру первого видимого элемента и сколько таких элементов до нужного экрана  
        //count - количество, sizeOfElements - если влазит не ровное количество, то немного уменьшаем размер елемента
        {

            var elementCoordinates = _driver.FindElement(element).Coordinates;
            int elementXCoordinate = elementCoordinates.LocationInDom.X;
            var windowSize = _driver.Manage().Window.Size;
            int elementYmaxCoordinate = windowSize.Height - 100;
            var elementSize = _driver.FindElement(element).Size;
            int elementWidth = elementSize.Width;
            int elementHeight = elementSize.Height;
            while (count > 0)
            {
                new TouchAction(_driver)
                    .Press(elementXCoordinate + elementWidth / 2, elementYmaxCoordinate)
                    .Wait(100)
                    .MoveTo(elementXCoordinate + elementWidth / 2, elementYmaxCoordinate - elementHeight / sizeOfElement)
                    .Wait(100)
                    .Release()
                    .Perform();
                count--;
            }
        }        
    }
}