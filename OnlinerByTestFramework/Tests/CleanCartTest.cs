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

        [Fact(DisplayName = "Cleaning out the shopping cart should be successfully")]
        public void CleanCart_DeleteSelectedGood_DeletedSuccessfully()
        {
            var searchItemSteps = new SearchSteps(_fixture.Driver);
            var addToCartSteps = new AddToCart(_fixture.Driver);
            var cleanCartSteps = new CleanCartSteps(_fixture.Driver);

            searchItemSteps.SearchItem(GoodsAndModels.Products.ProductTv);
            addToCartSteps.SelectGoodByModel(GoodsAndModels.Models.TvModel)
                .AddGoodToCart();
            cleanCartSteps.DeleteSelectedGood()
                .MessageShouldBe(Messages.DeleteMessage);
        }
    }
}
