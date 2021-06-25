using System.Threading;
using OnlinerByTestFramework.Fixtures;
using OnlinerByTestFramework.Pages;
using OnlinerByTestFramework.Steps;
using Xunit;

namespace OnlinerByTestFramework.Tests
{
    public class CleanCartTest : IClassFixture<TestFixture>
    {
        private readonly TestFixture _fixture;
        private readonly CartPage _cartPage;


        public CleanCartTest(TestFixture fixture)
        {
            _fixture = fixture;
            _cartPage = new CartPage(_fixture.Driver);
        }

        [Fact]
        public void DeleteSelectedGood_FromCart()
        {
            var cleanCartSteps = new CleanCartSteps(_fixture.Driver);

            cleanCartSteps.OpenCatalog()
                .ChooseModel()
                .AddTheGood()
                .DeleteSelectedGood()
                .MessageVerification();

        }
    }
}