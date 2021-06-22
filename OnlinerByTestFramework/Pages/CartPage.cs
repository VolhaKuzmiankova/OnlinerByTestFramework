using OnlinerByTestFramework.Pages.Base;
using OnlinerByTestFramework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace OnlinerByTestFramework.Pages
{
    public class CartPage : BasePage
    {
        private Waits _wait;
        private static readonly By DeleteButtonSelector = By.XPath("//div[@class='cart-form__control'][1]");
        private static readonly By CartFormSelector = By.LinkText("Перейти к оформлению");


        public CartPage(IWebDriver driver) : base(driver)
        {
            _wait = new Waits(driver);
        }

        public CartPage DeleteGood()
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_wait.GetVisible(DeleteButtonSelector))
                .Build()
                .Perform();
            return this;
        }
    }
}