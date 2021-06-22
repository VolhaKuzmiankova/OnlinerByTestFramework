using OnlinerByTestFramework.Pages.Base;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Pages
{
    public class HomePage : BasePage
    {
        private static readonly By GoodsTypeSelector = By.XPath("//span[contains(text(),'Телевизоры')]");
        
        public HomePage(IWebDriver driver) : base(driver)
        {
        }
        
        public CatalogSamsungPage OpenCatalog()
        {
            _driver.FindElement(GoodsTypeSelector).Click();
            return new CatalogSamsungPage(_driver);
        }
        
        
    }
}