using OnlinerByTestFramework.Constants;
using OnlinerByTestFramework.Pages.Base;
using OnlinerByTestFramework.Utils;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Pages
{
    public class CartPage : BasePage
    {
        private static readonly By DeleteButtonSelector = By.XPath("//div[@class='cart-form__control'][1]");
        private static readonly By MessageSelector = By.XPath($" //div[contains(text(),'{TypeOfGoods.TvModel}')]");

        public CartPage(IWebDriver driver) : base(driver, DeleteButtonSelector, PageName.CartPage)
        {
        }

        public CartPage DeleteGood()
        {
            Action.MoveToElementAndClick(Driver, DeleteButtonSelector);

            return this;
        }

        public string GetMessage()
        {
            return Waits.WaitToBeVisible(Driver, MessageSelector).Text;
        }
    }
}