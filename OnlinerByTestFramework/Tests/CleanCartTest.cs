using System;
using OnlinerByTestFramework.Fixtures;
using OnlinerByTestFramework.Pages;
using OnlinerByTestFramework.Steps;
using Xunit;

namespace OnlinerByTestFramework.Tests
{
    public class CleanCartTest : IClassFixture<TestFixture>
    {
        private string Url = Startup.AppSettings.Services.OnlinerByApp.AppUrl;

        private TestFixture _fixture;


        public CleanCartTest(TestFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void LoginTest_WithValidCredential()
        {
            _fixture.Driver.Navigate().GoToUrl(Url);
            var homePage = new HomePage(_fixture.Driver);
            var catalogPage = new CatalogSamsungPage(_fixture.Driver);
            var goodsPage = new GoodsPage(_fixture.Driver);
            var cartPage = new CartPage(_fixture.Driver);


            var cleanCartSteps = new CleanCartSteps(homePage, catalogPage, goodsPage, cartPage);

            cleanCartSteps.OpenCatalog();

            cleanCartSteps.ChooseModel();

            cleanCartSteps.AddTheGood();

            cleanCartSteps.DeleteSelectedGood();
        }
    }
}