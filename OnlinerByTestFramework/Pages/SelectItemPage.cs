using OnlinerByTestFramework.Constants;
using OnlinerByTestFramework.Pages.Base;
using OnlinerByTestFramework.Wrappers;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Pages
{
    public class SelectItemPage : BasePage
    {
        private static readonly By ModelSelector = By.XPath($"//span[contains (text(), '{GoodsAndModels.Models.TvModel}')]");
        public SelectItemPage(IWebDriver driver) : base(driver, ModelSelector, PageName.CatalogPage)
        {
        }

        public GoodsPage OpenGoodsPage(string model)
        {
            new WebElement("TV's model", Driver, ModelSelector).Click();


            return new GoodsPage(Driver);
        }
    }
}
