namespace AppiumConsole
{
    using System;
    using OpenQA.Selenium.Appium;
    using OpenQA.Selenium.Appium.Android;
    using OpenQA.Selenium.Appium.Enums;

    class Program
    {
        static void Main(string[] args)
        {
            /// Assumption: Appium is running with it's default settings

            /// Assumption: Android v9 emulator is running

            /// Assumption: https://www.appsapk.com/calculator/ is downloaded to C://temp

            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.FullReset, false);
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.NoReset, true);
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "emulator-5554");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "9");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.App, "C:\\Temp\\Calculator.apkpure.com.apk");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.NewCommandTimeout, 60);
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.AutomationName, "uiautomator2");
            var _driver = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub/"), appiumOptions);

            _driver.ClickByText("9");

            _driver.ClickByText("3");

            _driver.ClickByText("8");

            _driver.Quit();
        }
    }
}
