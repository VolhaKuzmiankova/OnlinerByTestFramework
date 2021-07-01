using OnlinerByTestFramework.Constants;
using OnlinerByTestFramework.Pages.Base;
using OnlinerByTestFramework.Wrappers;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Pages
{
    public class HomePage : BasePage
    {
        private static readonly By CatalogSelector =
            By.XPath($"//span[contains(text(),'{TypeOfGoods.Products.ProductTv}')]");

        public HomePage(IWebDriver driver) : base(driver, CatalogSelector, PageName.HomePage)
        {
        }

        public CatalogPage OpenCatalog(string product)
        {
            new WebElement("Product Catalog", Driver, CatalogSelector).Click();

            return new CatalogPage(Driver);
        }
    }
}