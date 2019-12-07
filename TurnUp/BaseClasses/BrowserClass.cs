using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using NUnit.Framework;
using TurnUp.Settings;
using TurnUp.Configuration;
using TurnUp.CustomExceptions;

namespace TurnUp.BaseClasses
{
    [TestFixture]
    public class BrowserClass
    {
        // Get the Chrome Browser
        private static IWebDriver GetChromeWebDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }

        // Get the FireFox Browser
        private static IWebDriver GetFireFoxWebDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }

        // Get the IE Browser
        private static IWebDriver GetIEWebDriver()
        {
            IWebDriver driver = new InternetExplorerDriver();
            return driver;
        }

        // Should run before every test to initialize the driver
        [OneTimeSetUp]
        public void InitWebDriver()
        {
            ObjectRespository.config = new AppConfigReader();

            switch (ObjectRespository.config.GetBrowser())
            {
                case BrowserType.Chrome:
                    ObjectRespository.driver = GetChromeWebDriver();
                    break;

                case BrowserType.Firefox:
                    ObjectRespository.driver = GetFireFoxWebDriver();
                    break;

                case BrowserType.IE:
                    ObjectRespository.driver = GetIEWebDriver();  
                    break;

                default:
                    throw new NoSuchDriverFound("Suitable Driver is not found: "+ObjectRespository.driver.ToString());
            }
        }

        //Should Quit the Driver 
        [OneTimeTearDown]
        public static void QuitDriver()
        {
            ObjectRespository.driver.Quit();
        }


    }
}
