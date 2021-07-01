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

        [Fact(DisplayName = "Cleaning out the shopping cart")]
        public void CleanCart_DeleteSelectedGood_DeletedSuccessfully()
        {
            var cleanCartSteps = new CleanCartSteps(_fixture.Driver);

            cleanCartSteps.OpenCatalog(TypeOfGoods.Products.ProductTv)
                .ChooseModel(TypeOfGoods.Models.TvModel)
                .AddGoodToCart()
                .DeleteSelectedGood()
                .MessageShouldBe(Messages.DeleteMessage);
        }
    }
}
