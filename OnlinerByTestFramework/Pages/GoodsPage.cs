using OnlinerByTestFramework.Pages.Base;
using OnlinerByTestFramework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace OnlinerByTestFramework.Pages
{
    public class GoodsPage : BasePage
    {
        private WebDriverWait _wait;

        private static readonly By BuyButtonSelector = By.LinkText("В корзину");

        private static readonly By ToCartButtonSelector = By.LinkText("В корзине");


        public GoodsPage(IWebDriver driver) : base(driver)
        {
        }

        public GoodsPage ClickButton()
        {
            _driver.FindElement(BuyButtonSelector).Click();
            return this;
        }

        public GoodsPage GoToCart()
        {
            var cartButton = new Waits(_driver).GetClickable(ToCartButtonSelector);
            cartButton.Click();
            return this;
        }
    }
}