using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace OnlinerByTestFramework
{
    public class FirstTest
    {
        private IWebDriver Driver;
        
        [Fact]
        public void Test1()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(Startup.AppSettings.Services.OnlinerByApp.AppUrl);
            Driver.Quit();
        }
    }
}