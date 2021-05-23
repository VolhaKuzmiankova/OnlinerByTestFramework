using OnlinerByTestFramework.Fixtures;
using Xunit;

namespace OnlinerByTestFramework.Tests.Base
{
    public class BaseTest :IClassFixture<DriverFixture>
    {
        protected DriverFixture _fixture;
        
        public BaseTest(DriverFixture fixture)
        {
            _fixture = fixture;
        }

    }
}