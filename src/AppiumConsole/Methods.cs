namespace AppiumConsole
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Appium;
    using OpenQA.Selenium.Appium.Android;

    public static class Methods
    {
        internal static void ClickByText(this AndroidDriver<AppiumWebElement> driver,
                                        string text)
        {
            foreach (IWebElement webElement in driver.FindElementsByXPath("//*"))
            {
                if (webElement.Text == text)
                {
                    webElement.Click();
                }
            }
        }
    }
}