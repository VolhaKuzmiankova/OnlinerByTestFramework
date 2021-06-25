using OnlinerByTestFramework.Constants;
using OnlinerByTestFramework.Pages.Base;
using OnlinerByTestFramework.Utils;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Pages
{
    public class CartPage : BasePage
    {
        private readonly Action _action;
        private static readonly By DeleteButtonSelector = By.XPath("//div[@class='cart-form__control'][1]");
        private static readonly By MessageSelector = By.XPath("//*[contains (text(), 'удалили')]");

        public CartPage(IWebDriver driver) : base(driver, DeleteButtonSelector,PageName.CartPage )
        {
            _action = new Action(driver);
        }

        public CartPage DeleteGood()
        {
            _action.MoveToElementAndClick(DeleteButtonSelector);

            return this;
        }

        public string Message()
        {
           return Waits.GetElementVisible(MessageSelector).Text;
            
        }
        
    }
}