using System;
using OnlinerByTestFramework.Utils;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Pages.Base
{
    public abstract class BasePage
    {
        protected readonly IWebDriver Driver;
        private readonly By locator;
        private readonly string _pageName;

        protected BasePage(IWebDriver driver, By locator, string pageName)
        {
            Driver = driver;
            _pageName = pageName;
            this.locator = locator;
        }

        public void IsPageOpened()
        {
            var isVisible = Waits.IsElementVisible(Driver, locator);
            if (!isVisible)
            {
                throw new Exception($"Page is not opened {_pageName}");
            }
        }
    }
}