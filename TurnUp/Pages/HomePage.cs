using System;
using NUnit.Framework;
using OpenQA.Selenium;

using TurnUp.BaseClasses;
using TurnUp.Configuration;
using TurnUp.Interface;
using TurnUp.Settings;

namespace TurnUp.Pages
{
    public class HomePage: BrowserClass
    {
        [SetUp]
        public static void BeforeEveryTest()
        {
            INavigation navigate = ObjectRespository.driver.Navigate();
            navigate.GoToUrl(ObjectRespository.config.GetWebsiteUrl());

            //Login into the website
            LoginPage login = new LoginPage();
            login.LoginInSuccess(ObjectRespository.driver);
        }

        [TearDown]
        public static void AfterEveryTest()
        {
            ObjectRespository.driver.Close();
        }

        [Test]
        public void createTimeMaterial()
        {
            NaviageteToAdmin();

            TimeMaterialPage time = new TimeMaterialPage();
            time.createTimeAndMaterial(ObjectRespository.driver);
        }

        [Test]
        public void editTimeMaterial()
        {
            NaviageteToAdmin();
            
            TimeMaterialPage time = new TimeMaterialPage();
            time.editTimeAndMaterial(ObjectRespository.driver);
        }

        [Test]
        public void deleteTimeMaterial()
        {
            NaviageteToAdmin();

            TimeMaterialPage time = new TimeMaterialPage();
            time.deleteTimeAndMaterial(ObjectRespository.driver);
        }


        private void NaviageteToAdmin()
        {
            //Naviagte to the Administaror and Time and Materials
            AdminPage admin = new AdminPage();
            admin.clickAdministration(ObjectRespository.driver);
            admin.clickTimeMaterial(ObjectRespository.driver);
        }
    }
}
