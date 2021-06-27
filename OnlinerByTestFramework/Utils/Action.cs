using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace OnlinerByTestFramework.Utils
{
    public class Action
    {
        private static Action _instance;
        private Waits _waits;
        private readonly Actions _actions;

        public static Action GetInstance(IWebDriver driver)
        {
            return _instance ??= new Action(driver);
        }

        private Action(IWebDriver driver)
        {
            _actions = new Actions(driver);
            _waits = Waits.GetInstance(driver);
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