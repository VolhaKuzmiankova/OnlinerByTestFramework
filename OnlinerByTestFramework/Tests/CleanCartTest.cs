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
        public void LoginTest_WithValidCredential()
        {
            var cleanCartSteps = new CleanCartSteps(_fixture.Driver);

            cleanCartSteps.OpenCatalog().ChooseModel().AddTheGood().DeleteSelectedGood();
        }
    }
}