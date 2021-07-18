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

        public static IWebDriver GetDriver(BrowserName name)
        {
            Console.WriteLine(Env.GetString("SELENIUM_HUB"));
            return name switch
            {
                BrowserName.Chrome => IsInsideContainer ? 
                    new RemoteWebDriver(new Uri(Env.GetString("SELENIUM_HUB")), DriverCapabilityGenerator.GetChromeOptions()) : 
                    new ChromeDriver(DriverCapabilityGenerator.GetChromeOptions()),
                BrowserName.FireFox => IsInsideContainer ? 
                    new RemoteWebDriver(new Uri(Env.GetString("SELENIUM_HUB")), DriverCapabilityGenerator.GetFireFoxOptions()) :
                    new FirefoxDriver(DriverCapabilityGenerator.GetFireFoxOptions()),
                _ => new ChromeDriver()
            };
        }
    }
}
