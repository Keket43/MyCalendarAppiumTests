using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using System;


namespace QuizletUIAppiumTests.Drivers
{
    class AppiumDriver
    {
        private AppiumDriver<AndroidElement> _driver;

        public AppiumDriver<AndroidElement> InitializeAppium()
        {
            var driverOptions = new AppiumOptions();
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");

            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "10.0");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Pixel XL");
            // driverOptions.AddAdditionalCapability(MobileCapabilityType.App, "D:\\загрузки\\Quizlet Learn Languages Vocab with Flashcards_v6.4.2_apkpure.com.apk");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.App, "C:\\Users\\Ket\\Desktop\\app-release (12).apk");
            //driverOptions.AddAdditionalCapability("AppWaitActivity", "com.quizlet.quizletandroid.ui.intro.IntroActivity");

            var appiumService = new AppiumServiceBuilder()
                .WithIPAddress("127.0.0.1")
                .UsingAnyFreePort()
                .Build();

            if (!appiumService.IsRunning)
            {
                appiumService.Start();
            }

            _driver = new AndroidDriver<AndroidElement>(appiumService, driverOptions, TimeSpan.FromSeconds(180));
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return _driver;
        }
    }
}