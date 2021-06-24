using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace OnlinerByTestFramework.Utils
{
    public class Waits
    {
        private WebDriverWait _wait;

        public Waits(IWebDriver driver)
        {
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
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

        public IWebElement GetClickable(By by)
        {
            return _wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        public IWebElement GetElementVisible(By by)
        {
            return _wait.Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}