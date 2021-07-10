using OnlinerByTestFramework.Constants;
using OnlinerByTestFramework.Pages.Base;
using OnlinerByTestFramework.Wrappers;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Pages
{
    public class LoginPage : BasePage
    {
        private static readonly By ButtonSelector = By.XPath("//div[@class='auth-bar__item auth-bar__item--text']");

        private static readonly By EmailSelector = By.XPath("//input[@placeholder ='Ник или e-mail']");

        private static readonly By PasswordSelector = By.XPath("//input[@placeholder ='Пароль']");

        private static readonly By LoginButtonSelector = By.XPath("//*[@class ='auth-form__control auth-form__control_condensed-additional']");

        public LoginPage(IWebDriver driver) : base(driver, ButtonSelector, PageName.LoginPage)
        {
        }

        public LoginPage OpenForm()
        {
            new WebElement("EnterButton", Driver, ButtonSelector).Click();

            return this;
        }

        public LoginPage InputUsername(string username)
        {
            new WebElement("UsernameInput", Driver, EmailSelector).SendKeys(username);

            return this;
        }

        public LoginPage InputPassword(string password)
        {
            new WebElement("PasswordInput", Driver, PasswordSelector).SendKeys(password);

            return this;
        }

        public LoginPage SubmitForm()
        {
            new WebElement("LoginButton", Driver, LoginButtonSelector).Click();

            return this;
        }
    }
}
