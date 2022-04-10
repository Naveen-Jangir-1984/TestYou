using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestYou.Utilities
{
    public class CommonFunctions
    {
        private static DefaultWait<IWebDriver> FluentWait;
        private static readonly int Timeout = 60;

        public static void WaitAndEnterValueInTextField(WebDriver driver, By element, String value)
        {
            FluentWait = new(driver)
            {
                Timeout = TimeSpan.FromSeconds(Timeout),
                PollingInterval = TimeSpan.FromSeconds(5)
            };
            FluentWait.Until(x => x.FindElement(element));

            driver.FindElement(element).Clear();
            driver.FindElement(element).SendKeys(value);
        }
        public static void WaitAndClickOnButton(WebDriver driver, By element)
        {
            FluentWait = new(driver)
            {
                Timeout = TimeSpan.FromSeconds(Timeout),
                PollingInterval = TimeSpan.FromSeconds(5)
            };
            FluentWait.Until(x => x.FindElement(element));
            driver.FindElement(element).Click();
        }
        public static String WaitAndGetText(WebDriver driver, By element)
        {
            FluentWait = new(driver)
            {
                Timeout = TimeSpan.FromSeconds(Timeout),
                PollingInterval = TimeSpan.FromSeconds(5)
            };
            FluentWait.Until(x => x.FindElement(element));
            return driver.FindElement(element).Text;
        }
    }
}
