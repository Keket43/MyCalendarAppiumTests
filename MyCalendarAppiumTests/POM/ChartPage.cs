using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System;

namespace mibileTest
{
    public class ChartPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public ChartPage(AppiumDriver<AndroidElement> driver)
        {
            _driver = driver;
        }

        private readonly By _addCharackter = By.Id("com.popularapp.periodcalendar:id/bt_add");
        private readonly By _weightChangeField = By.Id("com.popularapp.periodcalendar:id/weight_unit");
        private readonly By _heightChangeField = By.Id("com.popularapp.periodcalendar:id/height_unit");
        private readonly By _weightField = By.Id("com.popularapp.periodcalendar:id/weight");
        private readonly By _heightField = By.Id("com.popularapp.periodcalendar:id/height");
        private readonly By _weightChangeKg = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android" +
            ".widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.FrameLayout/android.widget.ListView/" +
            "android.widget.CheckedTextView[2]");
        private readonly By _heightChangeSm = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android" +
            ".widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.FrameLayout/android.widget.ListView/" +
            "android.widget.CheckedTextView[1]");
        private readonly By _saveChanges = By.Id("com.popularapp.periodcalendar:id/bt_right");
        private readonly By _backInMainPage = By.Id("com.popularapp.periodcalendar:id/bt_back");

        public ChartPage AddCharackter()
        {
            _driver.FindElement(_addCharackter).Click();
            return this;
        }

        public ChartPage WeightChangeField()
        {
            _driver.FindElement(_weightChangeField).Click();
            return this;
        }

        public ChartPage HeightChangeField()
        {
            _driver.FindElement(_heightChangeField).Click();
            return this;
        }

        public ChartPage WeightChangeKg()
        {
            _driver.FindElement(_weightChangeKg).Click();
            return this;
        }

        public ChartPage HeightChangeSm()
        {
            _driver.FindElement(_heightChangeSm).Click();
            return this;
        }

        public ChartPage WeightField(string kg)
        {
            _driver.FindElement(_weightField).Clear();
            _driver.FindElement(_weightField).SendKeys(kg);
            return this;
        }

        public ChartPage HeightField(string sm)
        {
            _driver.FindElement(_heightField).Clear();
            _driver.FindElement(_heightField).SendKeys(sm);
            return this;
        }

        public ChartPage SaveChanges()
        {
            _driver.FindElement(_saveChanges).Click();
            return this;
        }

        public ChartPage BackInMainPage()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(_backInMainPage));
            _driver.FindElement(_backInMainPage).Click();
            return this;
        }
    }
}