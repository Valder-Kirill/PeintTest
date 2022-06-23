using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace PaintProject.Drivers
{
    public static class PaintDriver
    {
        private static AppiumDriver<WindowsElement> _driver;

        public static AppiumDriver<WindowsElement> GetDriver()
        {
            return _driver;
        }

        public static void SetDriver(string appName)
        {
            if (_driver == null)
            {
                var options = new AppiumOptions();
                options.AddAdditionalCapability("app", appName);
                options.AddAdditionalCapability("deviceName", "WindowsPC");
                _driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), options);
                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            }
        }
    }
}
