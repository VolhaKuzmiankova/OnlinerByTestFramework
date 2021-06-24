using OnlinerByTestFramework.Pages.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace OnlinerByTestFramework.Pages
{
    public class CartPage : BasePage
    {
        private static readonly By DeleteButtonSelector = By.XPath("//div[@class='cart-form__control'][1]");
        private static readonly By MessageSelector = By.XPath("//*[contains (text(), 'удалили')]");

        public CartPage(IWebDriver driver) : base(driver, DeleteButtonSelector,Constants.PageName.CartPage )
        {
        }

        public CartPage DeleteGood()
        {
            var actions = new Actions(Driver);
            actions.MoveToElement(Waits.GetElementVisible(DeleteButtonSelector))
                .Build()
                .Perform();
            
            return this;
        }
    }
}