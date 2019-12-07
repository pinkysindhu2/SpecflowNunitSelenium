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
       
        //Login into website
        public void LoginInSuccess(IWebDriver driver)
        {
            // Defining the web elements with HTML corresponding elements
            IWebElement email = driver.FindElement(By.Name("UserName"));
            IWebElement password = driver.FindElement(By.Name("Password"));
            IWebElement submit = driver.FindElement(By.CssSelector("input.btn.btn-default"));

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
