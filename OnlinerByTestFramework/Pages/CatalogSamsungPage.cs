using OnlinerByTestFramework.Constants;
using OnlinerByTestFramework.Pages.Base;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Pages
{
    public class CatalogSamsungPage : BasePage
    {

        public CatalogSamsungPage(IWebDriver driver) : base(driver, GetLocator(DataForLocator.TVModel), PageName.CatalogPage)
        {
        }
        private static By GetLocator(string model)
        {
            return By.XPath($"//*[contains (text(), '{model}')]");
        }

        public GoodsPage OpenGoodsPage(string model)
        {
            Driver.FindElement(GetLocator(model)).Click();

            return new GoodsPage(Driver);
        }
    }
}