using DotNetEnv;
using OnlinerByTestFramework.Fixtures;
using OnlinerByTestFramework.Steps;
using Xunit;

namespace OnlinerByTestFramework.Tests
{
    public class LoginTest : IClassFixture<TestFixture>
    {
        private readonly TestFixture _fixture;
        private readonly string _username = Env.GetString("USERNAME");
        private readonly string _password = Env.GetString("PASSWORD");


        public LoginTest(TestFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact(DisplayName = "Login with valid credential")]
        public void LoginTest_WithValidCredential()
        {
            var loginSteps = new LoginSteps(_fixture.Driver);

            loginSteps.OpenLoginForm().Login(_username, _password);
        }
    }
}
