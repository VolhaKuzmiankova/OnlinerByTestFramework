using OnlinerByTestFramework.Fixtures;
using OpenQA.Selenium;
using Xunit;

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