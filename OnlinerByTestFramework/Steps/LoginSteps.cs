using OnlinerByTestFramework.Pages;

namespace OnlinerByTestFramework.Steps
{
    public class LoginSteps
    {
        private readonly LoginPage _loginPage;

        public LoginSteps(LoginPage loginPage)
        {
            _loginPage = loginPage;
        }

        public HomePage Login(string username, string password)
        {
            return _loginPage.TypeUsername(username).TypePassword(password).SubmitForm();
        }
    }
}