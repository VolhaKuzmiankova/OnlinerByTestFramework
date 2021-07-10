using System.Collections.ObjectModel;
using OnlinerByTestFramework.Exceptions;
using OnlinerByTestFramework.Utils;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Wrappers
{
    public class WebElement
    {
        private readonly IWebDriver _driver;
        private readonly By _by;
        private IWebElement _element;

        public WebElement(string name, IWebDriver driver, By by)
        {
            _driver = driver;
            _by = by;
        }

        private IWebElement FindElement(By by)
        {
            try
            {
                _element = _driver.FindElement(by);
                return _element;
            }
            catch (NoSuchElementException ex)
            {
                throw new ElementException("Element does not exist", ex);
            }
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return _driver.FindElements(by);
        }

        public void Clear()
        {
            FindElement(_by).Clear();
        }

        public void SendKeys(string text)
        {
            FindElement(_by).SendKeys(text);
        }

        public void Submit()
        {
            FindElement(_by).Submit();
        }

        public void Click()
        {
            FindElement(_by).Click();
        }

        public void WaitAndClick()
        {
            Waits.IsElementVisible(_driver, _by);
            FindElement(_by).Click();
        }
    }
}
