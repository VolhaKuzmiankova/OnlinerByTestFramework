using OnlinerByTestFramework.Pages.Base;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Pages
{
    public class CatalogSamsungPage : BasePage
    {
        
        private static readonly By ModelSelector = By.XPath("//*[contains (text(), 'телевизор Samsung QE55Q70AAU')]");
            
        public CatalogSamsungPage(IWebDriver driver) : base(driver)
        {
        }

        public CatalogSamsungPage OpenGoodsPage()
        {
            _driver.FindElement(ModelSelector).Click();
            return this;
        }
    }
}