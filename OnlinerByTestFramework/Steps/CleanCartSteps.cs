using OnlinerByTestFramework.Pages;
using OnlinerByTestFramework.Steps.Base;
using OpenQA.Selenium;
using Xunit;

namespace OnlinerByTestFramework.Steps
{
    public class CleanCartSteps : BaseSteps
    {
        private readonly HomePage _homePage;
        private readonly CatalogPage _catalogPage;
        private readonly GoodsPage _goodsPage;
        private readonly CartPage _cartPage;


        public CleanCartSteps(IWebDriver driver) : base(driver)
        {
            _homePage = new HomePage(driver);
            _catalogPage = new CatalogPage(driver);
            _goodsPage = new GoodsPage(driver);
            _cartPage = new CartPage(driver);
        }

        public CleanCartSteps OpenCatalog(string product)
        {
            _homePage.OpenCatalog(product);

            return this;
        }

        public CleanCartSteps ChooseModel(string model)
        {
            _catalogPage.OpenGoodsPage(model);

            return this;
        }

        public CleanCartSteps AddGoodToCart()
        {
            _goodsPage.ClickBuyButton();
            _goodsPage.GoToCart();

            return this;
        }

        public CleanCartSteps DeleteSelectedGood()
        {
            _cartPage.DeleteGood();

            return this;
        }

        public CleanCartSteps MessageShouldBe(string expected)
        {
            Assert.StartsWith(expected, _cartPage.GetMessage());

            return this;
        }
    }
}