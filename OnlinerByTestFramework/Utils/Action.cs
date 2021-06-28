using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace OnlinerByTestFramework.Utils
{
    public static class Action
    {
        public static void MoveToElementAndClick(IWebDriver driver, By by)
        {
            new Actions(driver).MoveToElement(Waits.WaitToBeVisible(driver, by))
                .Click()
                .Build()
                .Perform();
        }
    }
}