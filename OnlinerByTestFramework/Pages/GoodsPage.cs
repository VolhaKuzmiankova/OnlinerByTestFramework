using OnlinerByTestFramework.Constants;
using OnlinerByTestFramework.Pages.Base;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Pages
{
    public class GoodsPage : BasePage
    {
        private static readonly By BuyButtonSelector = By.LinkText("В корзину");

        private static readonly By ToCartButtonSelector = By.LinkText("В корзине");


        public GoodsPage(IWebDriver driver) : base(driver, BuyButtonSelector, PageName.GoodsPage)
        {
        }

        public GoodsPage ClickBuyButton()
        {
            Driver.FindElement(BuyButtonSelector).Click();

            return this;
        }

        public CartPage GoToCart()
        {
            var cartButton = Waits.WaitToBeClickable(ToCartButtonSelector);
            cartButton.Click();

            return new CartPage(Driver);
        }
    }
}