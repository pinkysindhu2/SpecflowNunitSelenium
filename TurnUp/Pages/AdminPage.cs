using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TurnUp
{
    public class AdminPage
    {
        private IWebDriver driver;

        public AdminPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Click on the Administation
        public void clickAdministration()
        {
            // Locate and click on Adminstration
            IWebElement admin = this.driver.FindElement(By.XPath("//a[contains(.,'Administration')]"));
            admin.Click();

        }

        public void clickTimeMaterial()
        {
            //Locate and click on Time and Material
            IWebElement timematerial = this.driver.FindElement(By.XPath("//a[contains(.,'Time & Materials')]"));
            timematerial.Click();
        }

    }
}

