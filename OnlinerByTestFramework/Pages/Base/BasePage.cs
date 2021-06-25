using System;
using OnlinerByTestFramework.Utils;
using OpenQA.Selenium;

namespace OnlinerByTestFramework.Pages.Base
{
    public abstract class BasePage
    {
        protected readonly IWebDriver Driver;
        protected readonly Waits Waits;
        private readonly By locator;
        private readonly string _pageName;

        protected BasePage(IWebDriver driver, By locator, string pageName)
        {
            Driver = driver;
            Waits = new Waits(Driver);
            _pageName = pageName;
        }

        public void IsPageOpened()
        {
            var isVisible = Waits.IsElementVisible(locator);
            if (!isVisible)
            {
                throw new Exception($"Page is not opened {_pageName}");
            }
        }
    }
}