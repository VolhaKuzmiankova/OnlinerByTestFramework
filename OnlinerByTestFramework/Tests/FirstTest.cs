using System.Threading;
using OnlinerByTestFramework.Fixtures;
using OnlinerByTestFramework.Pages;
using OnlinerByTestFramework.Steps;
using OnlinerByTestFramework.Tests.Base;
using Xunit;

namespace OnlinerByTestFramework.Tests
{
    public class FirstTest : BaseTest
    {
        public FirstTest(DriverFixture fixture) : base(fixture)
        {
        }
        
        [Fact]
        public void Test1()
        {
            _fixture.Driver.Navigate().GoToUrl(Startup.AppSettings.Services.OnlinerByApp.AppUrl);
            var homePage = new HomePage(_fixture.Driver);

            var loginPage = homePage.OpenLoginForm();
            var loginSteps = new LoginSteps(loginPage);

            homePage = loginSteps.Login(Startup.AppSettings.Users.UserName, Startup.AppSettings.Users.Password);

            Thread.Sleep(2000);
        }
    }
}