using OnlinerByTestFramework.Fixtures;
using Xunit;

namespace OnlinerByTestFramework.Tests
{
    public class FirstTest : IClassFixture<DriverFixture>
    {
        private DriverFixture _fixture;

        public FirstTest(DriverFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Test1()
        {
            _fixture.Driver.Navigate().GoToUrl(Startup.AppSettings.Services.OnlinerByApp.AppUrl);
        }
    }
}