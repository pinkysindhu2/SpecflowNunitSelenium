using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TurnUp
{
    public class AdminPage
    {
       
        //Click on the Administation
        public void clickAdministration(IWebDriver driver)
        {
            // Locate and click on Adminstration
            IWebElement admin = driver.FindElement(By.XPath("//a[contains(.,'Administration')]"));
            admin.Click();

        }

        public void clickTimeMaterial(IWebDriver driver)
        {
            //Locate and click on Time and Material
            IWebElement timematerial = driver.FindElement(By.XPath("//a[contains(.,'Time & Materials')]"));
            timematerial.Click();
        }

    }
}

