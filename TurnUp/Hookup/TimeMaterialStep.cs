﻿using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TurnUp.Settings;

namespace TurnUp.Hookup
{
    [Binding]
    public class TimeMaterialStep
    {
        #region Given
        [Given(@"I have logged into TurnUp portal")]
        public void GivenIHaveLoggedIntoTurnUpPortal()
        {
            INavigation navigate = ObjectRespository.driver.Navigate();
            navigate.GoToUrl(ObjectRespository.config.GetWebsiteUrl());

            //Login into the website
            LoginPage login = new LoginPage();
            login.LoginInSuccess(ObjectRespository.driver);
        }

        [Given(@"I have navigated to Time and Material page")]
        public void GivenIHaveNavigatedToTimeAndMaterialPage()
        {
            AdminPage admin = new AdminPage();
            admin.clickAdministration(ObjectRespository.driver);
            admin.clickTimeMaterial(ObjectRespository.driver);
        }

        [Given(@"A table with TM records at Time and Material Page")]
        public void GivenATableWithTMRecordsAtTimeAndMaterialPage()
        {
            
        }
        #endregion

        #region When
        [When(@"I have clicked on the create new button")]
        public void WhenIHaveClickedOnTheCreateNewButton()
        {
            // Locate create new button and click on it
            IWebElement create = ObjectRespository.driver.FindElement(By.XPath("//a[@href='/TimeMaterial/Create']"));

            create.Click();
        }

        [When(@"Click on the next button on the bottom of the table")]
        public void WhenClickOnTheNextButtonOnTheBottomOfTheTable()
        {
           
        }

        [When(@"I have clicked on the Edit button")]
        public void WhenIHaveClickedOnTheEditButton()
        {
            
        }

        [When(@"I have clicked on the Delete button")]
        public void WhenIHaveClickedOnTheDeleteButton()
        {
            
        }
        #endregion

        #region Then
        [Then(@"I should be able to create a TM record successfully")]
        public void ThenIShouldBeAbleToCreateATMRecordSuccessfully()
        {
            
        }

        [Then(@"New TM record is listed into the table")]
        public void ThenNewTMRecordIsListedIntoTheTable()
        {

        }
        
        [Then(@"I should be able to edit a TM record successfully")]
        public void ThenIShouldBeAbleToEditATMRecordSuccessfully()
        {
            
        }

        [Then(@"I should be able to delete a TM record successfully")]
        public void ThenIShouldBeAbleToDeleteATMRecordSuccessfully()
        {
            
        }
        #endregion
    }
}
