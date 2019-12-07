using System;
using OpenQA.Selenium;
using TurnUp.Settings;

namespace TurnUp.Utilities
{
    public class WebElement
    {

        public static IWebElement GetElement(string locator, string path)
        {
            
            if (locator == "Id")
            {
                return ObjectRespository.driver.FindElement(By.Id(path));
            }
            else if (locator == "Name")
            {
                return ObjectRespository.driver.FindElement(By.Name(path));
            }
            else if (locator == "XPath")
            {
                return ObjectRespository.driver.FindElement(By.XPath(path));
            }
            else if (locator == "ClassName")
            {
                return ObjectRespository.driver.FindElement(By.ClassName(path));
            }
            else if (locator == "CssSelector")
            {
                return ObjectRespository.driver.FindElement(By.CssSelector(path));
            }
            else
            {
                throw new NoSuchElementException("No Such Web Element found at the given locator: " + locator + " and path : "+ path);
            }
        }
    }
}
