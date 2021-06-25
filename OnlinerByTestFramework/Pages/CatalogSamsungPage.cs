using OnlinerByTestFramework.Constants;
using OnlinerByTestFramework.Pages.Base;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Pages
{
    public class CatalogSamsungPage : BasePage
    {
        private static readonly By ModelSelector = By.XPath($"//span[contains (text(), '{TypeOfGoods.TvModel}')]");

        public CatalogSamsungPage(IWebDriver driver) : base(driver, ModelSelector,
            PageName.CatalogPage)
        {
        }

        public GoodsPage OpenGoodsPage(string model)
        {
            Driver.FindElement(ModelSelector).Click();

            return new GoodsPage(Driver);
        }
    }
}