using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace OnlinerByTestFramework.Pages.Base
{
    public abstract class BasePage
    {
        protected IWebDriver _driver;

        protected BasePage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}