using OnlinerByTestFramework.Pages;
using OnlinerByTestFramework.Steps.Base;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Steps
{
    public class AddToCart : BaseSteps
    {
        private readonly SelectItemPage _selectItemPagePage;
        private readonly GoodsPage _goodsPage;

        public AddToCart(IWebDriver driver) : base(driver)
        {
            _selectItemPagePage = new SelectItemPage(driver);
            _goodsPage = new GoodsPage(driver);
        }
        public AddToCart SelectGoodByModel(string model)
        {
            _selectItemPagePage.OpenGoodsPage(model);

            return this;
        }

        public AddToCart AddGoodToCart()
        {
            _goodsPage.ClickBuyButton();

            return this;
        }
    }
}
