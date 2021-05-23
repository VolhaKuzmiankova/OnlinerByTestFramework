using System;
using OnlinerByTestFramework.Pages.Base;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Pages
{
    public class HomePage: BasePage
    {
        private static readonly By ButtonSelector = By.XPath("//div[@class='auth-bar__item auth-bar__item--text']");
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public LoginPage OpenLoginForm()
        {
            _driver.FindElement(ButtonSelector).Click();
            return new LoginPage(_driver);
        }
    }
}