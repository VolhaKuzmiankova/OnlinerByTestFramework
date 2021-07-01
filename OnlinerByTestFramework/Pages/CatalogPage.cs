using OnlinerByTestFramework.Constants;
using OnlinerByTestFramework.Pages.Base;
using OnlinerByTestFramework.Wrappers;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Pages
{
    public class CatalogPage : BasePage
    {
        private static readonly By ModelSelector = By.XPath($"//span[contains (text(), '{TypeOfGoods.Models.TvModel}')]");

        public CatalogPage(IWebDriver driver) : base(driver, ModelSelector, PageName.CatalogPage)
        {
        }

        public GoodsPage OpenGoodsPage(string model)
        {
            new WebElement("TV's model", Driver, ModelSelector).Click();


            return new GoodsPage(Driver);
        }
    }
}
