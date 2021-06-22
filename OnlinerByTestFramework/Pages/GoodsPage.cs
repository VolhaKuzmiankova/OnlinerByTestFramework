using OnlinerByTestFramework.Pages.Base;
using OnlinerByTestFramework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace OnlinerByTestFramework.Pages
{
    public class GoodsPage : BasePage
    {
        private readonly Waits _wait;

        private static readonly By BuyButtonSelector = By.LinkText("В корзину");

        private static readonly By ToCartButtonSelector = By.LinkText("В корзине");


        public GoodsPage(IWebDriver driver) : base(driver)
        {
            _wait = new Waits(driver);
        }

        public GoodsPage ClickButton()
        {
            _driver.FindElement(BuyButtonSelector).Click();
            return this;
        }

        public CartPage GoToCart()
        {
            var cartButton = _wait.GetClickable(ToCartButtonSelector);
            cartButton.Click();
            return new CartPage(_driver);
        }
    }
}