using OnlinerByTestFramework.Constants;
using OnlinerByTestFramework.Pages;
using OnlinerByTestFramework.Steps.Base;
using OpenQA.Selenium;
using Xunit;

namespace OnlinerByTestFramework.Steps
{
    public class CleanCartSteps : BaseSteps
    {
        private readonly HomePage _homePage;
        private readonly CatalogSamsungPage _catalogSamsung;
        private readonly GoodsPage _goodsPage;
        private readonly CartPage _cartPage;

        public CleanCartSteps(IWebDriver driver) : base(driver)
        {
            _homePage = new HomePage(driver);
            _catalogSamsung = new CatalogSamsungPage(driver);
            _goodsPage = new GoodsPage(driver);
            _cartPage = new CartPage(driver);
        }

        public CleanCartSteps OpenCatalog()
        {
            _homePage.OpenCatalog(TypeOfGoods.ProductTv);

            return this;
        }

        public CleanCartSteps ChooseModel()
        {
            _catalogSamsung.OpenGoodsPage(TypeOfGoods.TvModel);

            return this;
        }

        public CleanCartSteps AddTheGood()
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