using OnlinerByTestFramework.Constants;
using OnlinerByTestFramework.Pages.Base;
using OnlinerByTestFramework.Utils;
using OnlinerByTestFramework.Wrappers;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Pages
{
    public class HomePage : BasePage
    {
        private static readonly By SearchInputSelector = By.ClassName("fast-search__input");

        private static readonly By CategoryOfGoodsSelector = By.CssSelector("li[data-bind*='search__result_active']:first-child");

        private static readonly By FrameSelector = By.ClassName("modal-iframe");

        public HomePage(IWebDriver driver) : base(driver, SearchInputSelector, PageName.HomePage)
        {
        }

        public SelectItemPage SearchItem(string item)
        {
            new WebElement("Search Field", Driver, SearchInputSelector).SendKeys(item);

            Waits.FrameToBeAvailableAndSwitchToIt(Driver, FrameSelector);
            new WebElement("Category of good", Driver, CategoryOfGoodsSelector).WaitAndClick();
            Driver.SwitchTo().DefaultContent();

            return new SelectItemPage(Driver);
        }
    }
}
