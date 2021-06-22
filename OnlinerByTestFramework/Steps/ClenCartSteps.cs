using OnlinerByTestFramework.Pages;

namespace OnlinerByTestFramework.Steps
{
    public class CleanCartSteps
    {
        private readonly LoginPage _loginPage;
        private readonly CatalogSamsungPage _catalogSamsung;
        private readonly GoodsPage _goodsPage;
        private readonly CartPage _cartPage;


        public CleanCartSteps(LoginPage loginPage, CatalogSamsungPage catalogSamsung, GoodsPage goodsPage,
            CartPage cartPage)
        {
            _loginPage = loginPage;
            _catalogSamsung = catalogSamsung;
            _goodsPage = goodsPage;
            _cartPage = cartPage;
        }

        public CleanCartSteps OpenCatalog()
        {
            _loginPage.OpenCatalog();
            return this;
        }

        public CleanCartSteps ChooseModel()
        {
            _catalogSamsung.OpenGoodsPage();
            return this;
        }

        public CleanCartSteps AddTheGood()
        {
            _goodsPage.ClickButton();
            _goodsPage.GoToCart();
            return this;
        }

        public CleanCartSteps DeleteSelectedGood()
        {
            _cartPage.DeleteGood();
            return this;
        }
    }
}