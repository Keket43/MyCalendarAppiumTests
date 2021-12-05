using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;

namespace QuizletUIAppiumTests.POM
{
    class StartPage
    {
        private AppiumDriver<AndroidElement> _driver;

        public StartPage(AppiumDriver<AndroidElement> webDriver)
        {
            _driver = webDriver;
        }

        [FindsBy(How = How.Id, Using = "#")]
        private AndroidElement searchText;


        public StartPage Search(string text)
        {
            searchText.SendKeys(text);
            return this;
        }

    }
}