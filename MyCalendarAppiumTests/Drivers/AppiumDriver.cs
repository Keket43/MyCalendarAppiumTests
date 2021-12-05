using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using System;

namespace MyCalendarAppiumTests
{
    class AppiumDriver
    {
        private AppiumDriver<AndroidElement> _driver;

        public AppiumDriver<AndroidElement> InittializeAppiumDriver()
        {
            var driverOptions = new AppiumOptions();
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "10");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Samsung Galaxy S10");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.AutomationName, "Appium");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.App, "D:\\krita\\com.popularapp.periodcalendar_1.740.242.gp_242.apk");

            var appiumService = new AppiumServiceBuilder()
                .WithIPAddress("127.0.0.1")
                .UsingAnyFreePort()
                .Build();//auto start server

            if (appiumService.IsRunning)
            {
                appiumService.Start();
            }

            _driver = new AndroidDriver<AndroidElement>(appiumService, driverOptions, TimeSpan.FromSeconds(100));
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return _driver;
        }
    }
}