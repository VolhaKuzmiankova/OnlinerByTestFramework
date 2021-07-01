using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace OnlinerByTestFramework.Utils
{
    public static class Waits
    {
        private const double waitForTimeOut = 10;

        public static bool IsElementVisible(IWebDriver driver, By by, double timeout = waitForTimeOut)
        {
            try
            {
                new WebDriverWait(driver,
                        TimeSpan.FromSeconds(timeout))
                    .Until(ExpectedConditions.ElementIsVisible(by));
            }
            catch (NoSuchElementException)
            {
                return false;
            }

            return true;
        }

        public static IWebElement WaitToBeClickable(IWebDriver driver, By by, double timeout = waitForTimeOut)
        {
            return new WebDriverWait(driver,
                    TimeSpan.FromSeconds(timeout))
                .Until(ExpectedConditions.ElementToBeClickable(by));
        }

        public static IWebElement WaitToBeVisible(IWebDriver driver, By by, double timeout = waitForTimeOut)
        {
            return new WebDriverWait(driver,
                    TimeSpan.FromSeconds(timeout))
                .Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}