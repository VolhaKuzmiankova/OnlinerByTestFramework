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

        public LoginSteps OpenLoginForm()
        {
              _loginPage.OpenForm();
              return this;

        }

        public LoginSteps Login (string username, string password)
        {
             _loginPage.TypeUsername(username).TypePassword(password).SubmitForm();
             return this;
        }
    }
}