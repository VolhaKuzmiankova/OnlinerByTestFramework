using OnlinerByTestFramework.Pages;
using OnlinerByTestFramework.Steps.Base;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Steps
{
    public class SearchSteps : BaseSteps
    {
        private readonly HomePage _homePage;

        public SearchSteps(IWebDriver driver) : base(driver)
        {
            _homePage = new HomePage(driver);
        }

        public SearchSteps SearchItem(string item)
        {
            _homePage.IsPageOpened();
            _homePage.SearchItem(item);

            return this;
        }
    }
}
