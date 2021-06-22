using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace OnlinerByTestFramework.Utils
{
    public class Waits
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public Waits(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
        }

        public IWebElement GetVisible(By by)
        {
           return _wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public IWebElement GetClickable(By by)
        {
            return _wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }
    }
}