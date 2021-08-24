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
            return name switch
            {
                BrowserName.Chrome => IsInsideContainer ? 
                    new RemoteWebDriver(new Uri(SeleniumHub), DriverCapabilityGenerator.GetChromeOptions()) : 
                    new ChromeDriver(DriverCapabilityGenerator.GetChromeOptions()),
                BrowserName.FireFox => IsInsideContainer ? 
                    new RemoteWebDriver(new Uri(SeleniumHub), DriverCapabilityGenerator.GetFireFoxOptions()) :
                    new FirefoxDriver(DriverCapabilityGenerator.GetFireFoxOptions()),
                _ =>new ChromeDriver(DriverCapabilityGenerator.GetChromeOptions())
            };
        }
    }
}
