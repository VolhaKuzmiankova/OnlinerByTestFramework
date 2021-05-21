using System;
using OnlinerByTestFramework.Factories;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Fixtures
{
    public class DriverFixture : IDisposable
    {
        public IWebDriver Driver { get; private set; }

        public DriverFixture()
        {
            Driver = DriverFactory.GetDriver(Startup.AppSettings.Configuration.Browser);
        }

        public void Dispose()
        {
            Driver.Quit();
        }
    }
}