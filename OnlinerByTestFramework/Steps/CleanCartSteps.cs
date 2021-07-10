using OnlinerByTestFramework.Pages;
using OnlinerByTestFramework.Steps.Base;
using OpenQA.Selenium;
using Xunit;

namespace OnlinerByTestFramework.Steps
{
    public class CleanCartSteps : BaseSteps
    {
        private readonly CartPage cartPage;

        public CleanCartSteps(IWebDriver driver) : base(driver)
        {
            cartPage = new CartPage(driver);
        }

        public CleanCartSteps DeleteSelectedGood()
        {
            var goodsPage = new GoodsPage(Driver);
            goodsPage.IsPageOpened();
            goodsPage.GoToCart();
            cartPage.IsPageOpened();
            cartPage.DeleteGood();

            return this;
        }

        public CleanCartSteps MessageShouldBe(string model, string expected)
        {
            Assert.StartsWith(expected, cartPage.GetMessage(model));

            return this;
        }
    }
}
