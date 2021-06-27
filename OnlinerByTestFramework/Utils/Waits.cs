using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace OnlinerByTestFramework.Utils
{
    public class Waits
    {
        private static Waits _instance;

        public static Waits GetInstance(IWebDriver driver)
        {
            return _instance ??= new Waits(driver);
        }

        private readonly WebDriverWait _wait;

        private Waits(IWebDriver driver)
        {
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Startup.AppSettings.Configuration.WaitTimeMin));
        }

        public bool IsElementVisible(By by)
        {
            try
            {
                _wait.Until(ExpectedConditions.ElementIsVisible(by));
            }
            catch (NoSuchElementException)
            {
                return false;
            }

            return true;
        }

        public IWebElement WaitToBeClickable(By by)
        {
            return _wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        public IWebElement WaitToBeVisible(By by)
        {
            return _wait.Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}