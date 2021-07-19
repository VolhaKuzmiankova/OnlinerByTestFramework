using System;
using DotNetEnv;
using OnlinerByTestFramework.Capabilities;
using OnlinerByTestFramework.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace OnlinerByTestFramework.Factories
{
    public static class DriverFactory
    {
        private static readonly bool IsInsideContainer = Env.GetBool("INSIDE_CONTAINER");
        private static readonly string SeleniumHub = Env.GetString("SELENIUM_HUB");

        public static IWebDriver GetDriver(BrowserName name)
        {
            var uri = new Uri(SeleniumHub);
            return name switch
            {
                BrowserName.Chrome => IsInsideContainer ? 
                    new RemoteWebDriver(uri, DriverCapabilityGenerator.GetChromeOptions()) : 
                    new ChromeDriver(DriverCapabilityGenerator.GetChromeOptions()),
                BrowserName.FireFox => IsInsideContainer ? 
                    new RemoteWebDriver(uri, DriverCapabilityGenerator.GetFireFoxOptions()) :
                    new FirefoxDriver(DriverCapabilityGenerator.GetFireFoxOptions()),
                _ =>new ChromeDriver(DriverCapabilityGenerator.GetChromeOptions())
            };
        }
    }
}
