using System.Threading;
using OnlinerByTestFramework.Fixtures;
using OnlinerByTestFramework.Pages;
using OnlinerByTestFramework.Steps;
using Xunit;

namespace OnlinerByTestFramework.Tests
{
    public class LoginTest : IClassFixture<DriverFixture>
    {
        private string Url = Startup.AppSettings.Services.OnlinerByApp.AppUrl;
        private string UserName = Startup.AppSettings.User.UserName;
        private string Password = Startup.AppSettings.User.Password;
        
        private DriverFixture _fixture;

        public LoginTest(DriverFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void TestLogin()
        {
            _fixture.Driver.Navigate().GoToUrl(Url);
            
            var loginPage = new LoginPage(_fixture.Driver);
            
            loginPage.OpenLoginForm();
            
            var loginSteps = new LoginSteps(loginPage);

            loginSteps.Login(UserName, Password);

            Thread.Sleep(2000);
        }
    }
}