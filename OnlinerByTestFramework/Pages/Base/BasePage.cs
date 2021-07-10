using System;
using OnlinerByTestFramework.Utils;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Pages.Base
{
    public abstract class BasePage
    {
        protected readonly IWebDriver Driver;
        private readonly By _locator;
        private readonly string _pageName;

        protected BasePage(IWebDriver driver, By locator, string pageName)
        {
            Driver = driver;
            _pageName = pageName;
            _locator = locator;
        }

        public void IsPageOpened()
        {
            var isVisible = Waits.IsElementVisible(Driver, _locator);
            if (!isVisible)
            {
                throw new Exception($"Page is not opened {_pageName}");
            }
        }
    }
}