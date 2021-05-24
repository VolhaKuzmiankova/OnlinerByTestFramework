﻿using OnlinerByTestFramework.Pages.Base;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Pages
{
    public class LoginPage : BasePage
    {
        private static readonly By ButtonSelector = By.XPath("//div[@class='auth-bar__item auth-bar__item--text']");
        private static readonly By EmailSelector = By.XPath("//*[@placeholder ='Ник или e-mail']");
        private static readonly By PasswordSelector = By.XPath("//*[@placeholder ='Пароль']");
        private static readonly By LoginButtonSelector = By.XPath("//*[@class ='auth-form__control auth-form__control_condensed-additional']");

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public void OpenLoginForm()
        {
            _driver.FindElement(ButtonSelector).Click();
        }

        public LoginPage TypeUsername(string username)
        {
            _driver.FindElement(EmailSelector).SendKeys(username);
            return this;
        }

        public LoginPage TypePassword(string password)
        {
            _driver.FindElement(PasswordSelector).SendKeys(password);
            return this;
        }

        public void SubmitForm()
        {
            _driver.FindElement(LoginButtonSelector).Click();
        }
    }
}