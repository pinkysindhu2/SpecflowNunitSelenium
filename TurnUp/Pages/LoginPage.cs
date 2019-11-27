using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using TurnUp.Pages;

namespace TurnUp
{

    public class LoginPage
    {
        private IWebDriver driver;
        //constructor
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        IWebElement email => this.driver.FindElement(By.Name("UserName"));
        IWebElement password => this.driver.FindElement(By.Name("Password"));
        IWebElement submit => this.driver.FindElement(By.CssSelector("input.btn.btn-default"));

        //Login into website
        public void LoginInSuccess()
        {
            // Sending the emial and password
            email.SendKeys("hari");
            password.SendKeys("123123");

            // Submiting the form
            submit.Submit();
        }

        //Login into website witj wrong password
        public void LoginInFailure()
        {
             // Sending the emial and password
            //email.SendKeys("hari");
            //password.SendKeys("123123");
            // Submiting the form
            //submit.Submit();
        }

    }
}
