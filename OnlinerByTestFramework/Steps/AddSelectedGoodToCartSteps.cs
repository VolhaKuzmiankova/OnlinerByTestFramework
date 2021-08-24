using OnlinerByTestFramework.Pages;
using OnlinerByTestFramework.Steps.Base;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Steps
{
    public class AddSelectedGoodToCartSteps : BaseSteps
    {
        public AddSelectedGoodToCartSteps(IWebDriver driver) : base(driver)
        {
        }

        public AddSelectedGoodToCartSteps AddGoodToCart()
        {
            var goodsPage = new GoodsPage(Driver);
            goodsPage.IsPageOpened();
            goodsPage.ClickBuyButton();

            return this;
        }
    }
}
