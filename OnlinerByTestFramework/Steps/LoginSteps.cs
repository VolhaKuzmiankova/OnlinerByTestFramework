using OnlinerByTestFramework.Pages;
using OnlinerByTestFramework.Steps.Base;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Steps
{
    public class LoginSteps : BaseSteps
    {
        private readonly LoginPage _loginPage;

        public LoginSteps(IWebDriver driver) : base(driver)
        {
            _loginPage = new LoginPage(driver);
        }

        public LoginSteps OpenLoginForm()
        {
            _loginPage.OpenForm();
            return this;
        }

        public LoginSteps Login(string username, string password)
        {
            _loginPage.TypeUsername(username).TypePassword(password).SubmitForm();
            return this;
        }
    }
}