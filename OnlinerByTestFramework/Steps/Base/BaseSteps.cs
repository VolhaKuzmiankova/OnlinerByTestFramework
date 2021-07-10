using OpenQA.Selenium;

namespace OnlinerByTestFramework.Steps.Base
{
    public class BaseSteps
    {
        protected readonly IWebDriver Driver;

        protected BaseSteps(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
