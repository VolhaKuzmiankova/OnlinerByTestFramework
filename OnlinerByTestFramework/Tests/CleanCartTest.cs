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

        [Fact]
        public void CleanCart_DeleteSelectedGood_DeletedSuccessfully()
        {
            var cleanCartSteps = new CleanCartSteps(_fixture.Driver);

            cleanCartSteps.OpenCatalog(TypeOfGoods.ProductTv)
                .ChooseModel(TypeOfGoods.TvModel)
                .AddTheGood()
                .DeleteSelectedGood()
                .MessageShouldBe(Messages.DeleteMessage);
        }
    }
}