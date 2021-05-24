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

        public void Login(string username, string password)
        {
            _loginPage.TypeUsername(username).TypePassword(password).SubmitForm();
        }
    }
}