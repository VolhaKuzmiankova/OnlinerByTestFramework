using System;
using OnlinerByTestFramework.Factories;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Fixtures
{
    public class TestFixture : IDisposable
    {
        public IWebDriver Driver { get; private set; }


        public TestFixture()
        {
            Driver = DriverFactory.GetDriver(Startup.AppSettings.Configuration.Browser);
        }

        public void Dispose()
        {
            Driver.Quit();
        }
    }
}