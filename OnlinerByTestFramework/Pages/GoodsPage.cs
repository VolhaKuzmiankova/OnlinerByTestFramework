using OnlinerByTestFramework.Constants;
using OnlinerByTestFramework.Pages.Base;
using OnlinerByTestFramework.Utils;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Pages
{
    public class GoodsPage : BasePage
    {
        private static readonly By BuyButtonSelector = By.LinkText("В корзину");

        private static readonly By ToCartButtonSelector = By.XPath("//*[text()='В корзине']");


        public GoodsPage(IWebDriver driver) : base(driver, BuyButtonSelector, PageName.GoodsPage)
        {
        }

        public GoodsPage ClickBuyButton()
        {
            Waits.WaitToBeClickable(Driver, BuyButtonSelector).Click();

            return this;
        }

        public CartPage GoToCart()
        {
            Waits.WaitToBeClickable(Driver, ToCartButtonSelector).Click();

            return new CartPage(Driver);
        }
    }
}