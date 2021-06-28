using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace OnlinerByTestFramework.Utils
{
    public static class Waits
    {
        public static bool IsElementVisible(IWebDriver driver, By by)
        {
            try
            {
                new WebDriverWait(driver,
                        TimeSpan.FromSeconds(Startup.AppSettings.Configuration.WaitForTimeout))
                    .Until(ExpectedConditions.ElementIsVisible(by));
            }
            catch (NoSuchElementException)
            {
                return false;
            }

            return true;
        }

        public static IWebElement WaitToBeClickable(IWebDriver driver, By by)
        {
            return new WebDriverWait(driver,
                    TimeSpan.FromSeconds(Startup.AppSettings.Configuration.WaitForTimeout))
                .Until(ExpectedConditions.ElementToBeClickable(by));
        }

        public static IWebElement WaitToBeVisible(IWebDriver driver, By by)
        {
            return new WebDriverWait(driver,
                    TimeSpan.FromSeconds(Startup.AppSettings.Configuration.WaitForTimeout))
                .Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}