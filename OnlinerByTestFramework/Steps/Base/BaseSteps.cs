using OpenQA.Selenium;

namespace OnlinerByTestFramework.Steps.Base
{
    public class BaseSteps
    {
        private IWebDriver _driver;

        protected BaseSteps(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}