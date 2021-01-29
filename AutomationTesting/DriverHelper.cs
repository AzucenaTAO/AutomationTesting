using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting
{
    public static class DriverHelper
    {
        public static void Click (By by)
        {
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(by));
            Driver.driver.FindElement(by).Click();
        }
        public static void SetText(By by, string text)
        {
             WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(by));
            Driver.driver.FindElement(by).SendKeys(text);
        }
        public static void MouseOver(By by)
        {
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(by));

            Actions action = new Actions(Driver.driver);
            action.MoveToElement(element).Perform();
        }
        public static string GetText(By by)
        {
             WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(by));
            return Driver.driver.FindElement(by).Text;
        }
    }
}
