using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace TurnUp.Utilities
{
    public class Sync
    {
        public Sync()
        {
        }
        // Generic method for explict wait until the item visible
        public static void waitVisibility(IWebDriver driver, string locator, string xpath, int sec)
        {   //Wait according to the locators
            if (locator == "Id")
            {
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, sec));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(xpath)));
            }
            if(locator == "XPath")
            {
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
            }
            if(locator == "Name")
            {
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(xpath)));
            }
        }

        // Generic method for explict wait until the item is available to click
        public static void waitElementToClick(IWebDriver driver, string locator, string xpath, int sec)
        {   //Wait according to the locators
            if (locator == "Id")
            {
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, sec));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(xpath)));
            }
            if (locator == "XPath")
            {
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpath)));
            }
            if (locator == "Name")
            {
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name(xpath)));
            }
        }
    }
}
