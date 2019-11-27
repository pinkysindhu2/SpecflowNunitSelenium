using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace TurnUp
{

    class Main
    {
       /* private IWebDriver driver;

        [SetUp]
        public  void BeforeEveryTest()
        {
            // Define Website url
            string url = "http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f";

            //Defining the WebDriver to be used in other classes
            driver = new ChromeDriver();

            //Login into the given Url
            LoginPage login = new LoginPage(driver);
            login.LoginInSuccess(url);
        }

        [TearDown]
        public void AfterEveryTest()
        {
            driver.Quit();
        }

        [Test]
        public void createTimeMaterial()
        {
            //Naviagte to the Administaror and Time and Materials
            AdminPage admin = new AdminPage(driver);
            admin.clickAdministration();
            admin.clickTimeMaterial();

            TimeMaterialPage time = new TimeMaterialPage(driver);
            time.createTimeAndMaterial();
        }

        [Test]
        public void verifyTimeMaterial()
        {
            //Naviagte to the Administaror and Time and Materials
            AdminPage admin = new AdminPage(driver);
            admin.clickAdministration();
            admin.clickTimeMaterial();

            TimeMaterialPage time = new TimeMaterialPage(driver);
            time.verifyTimeMaterialSaved();
        }

        [Test]
        public void editTimeMaterial()
        {   //Naviagte to the Administaror and Time and Materials
            AdminPage admin = new AdminPage(driver);
            admin.clickAdministration();
            admin.clickTimeMaterial();

            TimeMaterialPage time = new TimeMaterialPage(driver);
            time.editTimeAndMaterial();
        }

        [Test]
        public void deleteTimeMaterial()
        {   //Naviagte to the Administaror and Time and Materials
            AdminPage admin = new AdminPage(driver);
            admin.clickAdministration();
            admin.clickTimeMaterial();

            TimeMaterialPage time = new TimeMaterialPage(driver);
            time.deleteTimeAndMaterial();
        }

        [Test]
        public void dropDownSelection()
        {   //Naviagte to the Administaror and Time and Materials
            AdminPage admin = new AdminPage(driver);
            admin.clickAdministration();
            admin.clickTimeMaterial();

            // Locate create new button and click on it
            IWebElement create = this.driver.FindElement(By.XPath("//a[@href='/TimeMaterial/Create']"));

            create.Click();

            TimeMaterialPage timeMaterial = new TimeMaterialPage(driver);
            timeMaterial.dropDownList();

           
        }*/
    }
}
