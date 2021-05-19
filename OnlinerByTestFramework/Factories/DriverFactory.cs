using OnlinerByTestFramework.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace OnlinerByTestFramework.Factories
{
    public static class DriverFactory
    {
        public static IWebDriver GetDriver(BrowserName name)
        {
            switch (name)
            {
                case BrowserName.Chrome:
                    return new ChromeDriver();
                case BrowserName.FireFox:
                    return new FirefoxDriver();
                default:
                    return default;
            }
        }
    }
}