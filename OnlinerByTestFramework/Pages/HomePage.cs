using OnlinerByTestFramework.Constants;
using OnlinerByTestFramework.Pages.Base;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Pages
{
    public class HomePage : BasePage
    {
        private static readonly By CatalogSelector = By.XPath($"//span[contains(text(),'{TypeOfGoods.ProductTv}')]");

        public HomePage(IWebDriver driver) : base(driver, CatalogSelector, PageName.HomePage)
        {
        }

        public CatalogSamsungPage OpenCatalog()
        {
            Driver.FindElement(CatalogSelector).Click();

            return new CatalogSamsungPage(Driver);
        }
    }
}