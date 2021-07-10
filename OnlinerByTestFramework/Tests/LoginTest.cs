using OnlinerByTestFramework.Fixtures;
using OnlinerByTestFramework.Steps;
using Xunit;

namespace OnlinerByTestFramework.Tests
{
    public class LoginTest : IClassFixture<TestFixture>
    {
        private readonly string _userName = Startup.AppSettings.User.UserName;
        private readonly string _password = Startup.AppSettings.User.Password;

        private readonly TestFixture _fixture;

        public LoginTest(TestFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact(DisplayName = "Login with valid credential")]
        public void LoginTest_WithValidCredential()
        {
            var loginSteps = new LoginSteps(_fixture.Driver);

            loginSteps.OpenLoginForm().Login(_userName, _password);
        }
    }
}