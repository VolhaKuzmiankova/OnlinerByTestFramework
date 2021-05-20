using OnlinerByTestFramework.Factories;
using Xunit;

namespace OnlinerByTestFramework.Tests
{
    public class FirstTest
    {
        [Fact]
        public void Test1()
        {
            var driver = DriverFactory.GetDriver(Startup.AppSettings.Configuration.Browser);
            driver.Navigate().GoToUrl(Startup.AppSettings.Services.OnlinerByApp.AppUrl);
            driver.Quit();
        }
    }
}