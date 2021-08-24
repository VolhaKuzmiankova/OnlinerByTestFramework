using Allure.Xunit.Attributes;
using OnlinerByTestFramework.Constants;
using OnlinerByTestFramework.Fixtures;
using OnlinerByTestFramework.Steps;
using Xunit;

namespace OnlinerByTestFramework.Tests
{
    public class CleanCartTest : IClassFixture<TestFixture>
    {
        private readonly TestFixture _fixture;

        public CleanCartTest(TestFixture fixture)
        {
            _fixture = fixture;
        }

        [AllureXunit(DisplayName = "Cleaning out the shopping cart should be successfully")]
        public void CleanCart_DeleteSelectedGood_DeletedSuccessfully()
        {
            const string SelectedTvModel = "Samsung QE55Q77TAU";

            var searchItemSteps = new SearchSteps(_fixture.Driver);
            var addToCartSteps = new AddSelectedGoodToCartSteps(_fixture.Driver);
            var cleanCartSteps = new CleanCartSteps(_fixture.Driver);

            searchItemSteps.SearchItem($"{TypeOfGoods.Products.ProductTv} {SelectedTvModel}");
            addToCartSteps.AddGoodToCart();
            cleanCartSteps.DeleteSelectedGood()
                .MessageShouldBe(SelectedTvModel, Messages.DeleteMessage);
        }
    }
}
