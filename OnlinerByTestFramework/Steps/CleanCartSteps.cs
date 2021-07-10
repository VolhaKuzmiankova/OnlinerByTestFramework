using OnlinerByTestFramework.Pages;
using OnlinerByTestFramework.Steps.Base;
using OpenQA.Selenium;
using Xunit;

namespace OnlinerByTestFramework.Steps
{
    public class CleanCartSteps : BaseSteps
    {
        private readonly GoodsPage _goodsPage;
        private readonly CartPage _cartPage;

        public CleanCartSteps(IWebDriver driver) : base(driver)
        {
            _goodsPage = new GoodsPage(driver);
            _cartPage = new CartPage(driver);
        }

        public CleanCartSteps DeleteSelectedGood()
        {
            _goodsPage.GoToCart();
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
