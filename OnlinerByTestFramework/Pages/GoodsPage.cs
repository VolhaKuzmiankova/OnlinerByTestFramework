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
            Driver.FindElement(BuyButtonSelector).Click();

            return this;
        }

        public CartPage GoToCart()
        {
            Waits.GetInstance(Driver).WaitToBeClickable(ToCartButtonSelector).Click();

            return new CartPage(Driver);
        }
    }
}