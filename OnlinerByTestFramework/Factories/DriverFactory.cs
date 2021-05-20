using OnlinerByTestFramework.Capabilities;
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
            return name switch
            {
                BrowserName.Chrome => new ChromeDriver(DriverCapabilityGenerator.GetChromeOptions()),
                BrowserName.FireFox => new FirefoxDriver(DriverCapabilityGenerator.GetFireFoxOptions()),
                _ => new ChromeDriver()
            };
        }
    }
}