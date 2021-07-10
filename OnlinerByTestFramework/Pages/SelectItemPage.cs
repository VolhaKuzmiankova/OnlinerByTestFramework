using OnlinerByTestFramework.Constants;
using OnlinerByTestFramework.Pages.Base;
using OnlinerByTestFramework.Wrappers;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Pages
{
    public class SelectItemPage : BasePage
    {
        private static readonly By IsPageOpenedSelector = By.ClassName("schema-header__title");
        
        public SelectItemPage(IWebDriver driver) : base(driver, IsPageOpenedSelector, PageName.CatalogPage)
        {
        }
        
        public GoodsPage OpenGoodsPage(string model)
        {
            new WebElement("TV's model", Driver, By.XPath($"//span[contains (text(), '{model}')]")).Click();


            return new GoodsPage(Driver);
        }
    }
}
