using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace OnlinerByTestFramework.Utils
{
    public class Action
    {
        private  Actions _actions;
        private  Waits _waits;
        public Action(IWebDriver driver)
        {
            _actions = new Actions(driver);
            _waits = new Waits(driver);
        }

        public void MoveToElementAndClick(By by)
        {
            _actions.MoveToElement(_waits.WaitToBeVisible(by))
                .Click()
                .Build()
                .Perform();
        }
    }
}