using OnlinerByTestFramework.Fixtures;
using OnlinerByTestFramework.Pages;
using OnlinerByTestFramework.Steps;
using Xunit;

namespace OnlinerByTestFramework.Tests
{
    public class LoginTest : IClassFixture<TestFixture>
    {
        private string Url = Startup.AppSettings.Services.OnlinerByApp.AppUrl;
        
        private string UserName = Startup.AppSettings.User.UserName;
        
        private string Password = Startup.AppSettings.User.Password;
        
        private TestFixture _fixture;
        
        private LoginSteps _loginSteps;
        
        public LoginTest(TestFixture fixture)
        {
            _fixture = fixture;
            _loginSteps = new LoginSteps(new LoginPage(_fixture.Driver));
        }

        [Fact]
        public void LoginTest_WithValidCredential()
        {
            _fixture.Driver.Navigate().GoToUrl(Url);
            
            
            _loginSteps.OpenLoginForm().Login(UserName, Password);

        }
    }
}