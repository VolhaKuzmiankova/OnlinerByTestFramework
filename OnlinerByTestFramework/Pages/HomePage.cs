using OnlinerByTestFramework.Constants;
using OnlinerByTestFramework.Pages.Base;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver, GetLocator(DataForLocator.TypeOfGoods), PageName.HomePage)
        {
        }

        private static By GetLocator(string model)
        {
            return By.XPath($"//span[contains(text(),'{model}')]");
        }

        public CatalogSamsungPage OpenCatalog(string model)
        {
            Driver.FindElement(GetLocator(model)).Click();
            
            return new CatalogSamsungPage(Driver);
        }
        
    }
}