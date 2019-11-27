using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace TurnUp
{
    public class TimeMaterialPage
    {
        private IWebDriver driver;

        public TimeMaterialPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Create New TimeandMaterial
        public void createTimeAndMaterial()
        {

            // Locate create new button and click on it
            IWebElement create = this.driver.FindElement(By.XPath("//a[@href='/TimeMaterial/Create']"));

            create.Click();

            // find the fields in the form
            var code = this.driver.FindElement(By.Id("Code"));

            var description = this.driver.FindElement(By.Id("Description"));

            var price = this.driver.FindElement(By.XPath("//input[@tabindex='0']"));

            var save = this.driver.FindElement(By.Id("SaveButton"));

            // Access the TurnUp.xlxs file
            Utilities.ExcelHelper.PopulateInCollection("/Users/pinkysindhu/Desktop/Automation/TurnUp/TurnUp/Utilities/TurnUp.xlsx", "sheet1");
            
            // send data
            code.SendKeys(Utilities.ExcelHelper.ReadData(2,"Code"));
            description.SendKeys(Utilities.ExcelHelper.ReadData(2, "Description"));
            price.SendKeys(Utilities.ExcelHelper.ReadData(2, "Price"));

            //Click on save button
            save.Click();
        }

        //Verify Data using Next Button
        public void verifyTimeMaterialSaved()
        {
            Utilities.Sync.waitVisibility(driver,"XPath","//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr", 5);
            while (true)
            {   
                for (int i = 1; i <= 10; i++)
                {   
                    var code = this.driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]"));
                    var desc = this.driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[3]"));

                    if (code.Text == "1234" && desc.Text == "Automation Testing")
                    {
                        Console.WriteLine("Test is a success!!");
                        return;
                    }
                    IWebElement nextButton = this.driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[3]"));
                    nextButton.Click();
                }
            }
           
        }

        // Editting the fifth row of first column: Code 
        public void editTimeAndMaterial()
        {
            // Wait until the edit button is available using Xpath
            Utilities.Sync.waitVisibility(this.driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[1]/td[5]/a[1]", 10);
            // Locate the lastButton
            IWebElement editButton = this.driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[1]/td[5]/a[1]"));
            
            editButton.Click();

            // Wait until the edit button is available using Id
            Utilities.Sync.waitVisibility(this.driver, "Id", "container", 5);
            // Find the container on The Edit page
            IWebElement conatiner = this.driver.FindElement(By.Id("container"));
            //Find the code which is going to edit
            IWebElement inputCode = conatiner.FindElement(By.Id("Code"));
            inputCode.Clear();
            inputCode.SendKeys("100");
            IWebElement saveButton = conatiner.FindElement(By.Id("SaveButton"));
            saveButton.Click();

        }

        // Deleting the first row
        public void deleteTimeAndMaterial()
        {
            // Wait for Delete button appear.
            Utilities.Sync.waitVisibility(this.driver,"XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[1]/td[5]/a[2]", 10);

            // Click on the delete button
            IWebElement deleteButton = this.driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[1]/td[5]/a[2]"));

            deleteButton.Click();
            //Confirm Delete
            this.driver.SwitchTo().Alert().Accept();
            
        }


        //This method is using last buuton to verify the new created Time and Material
        public void IsDataSaved()
        {
            Console.WriteLine("Button0");
            // intilizing to store the data from the table
            List<string> code = new List<string>();
            List<string> description = new List<string>();
            List<string> price = new List<string>();

            // Using the wait driver to make lastbutton to appear on the page
            WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));

            // Locate the lastButton
            IWebElement lastButton = wait.Until<IWebElement>(d => d.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]")));

            // Click on the last buttom and checking the data is saved
            if (lastButton.Equals(this.driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]"))))
            {
                lastButton.Click();
                Console.WriteLine("Button2");
                // Locate table body
                IWebElement tableBody = this.driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody"));
                // Get the table rows
                IList<IWebElement> row = tableBody.FindElements(By.TagName("tr"));
                Console.WriteLine("Total row: " + row);

                // To get the coloums for each row
                for (int i = 0; i < row.Count; i++)
                {
                    IList<IWebElement> col = row[i].FindElements(By.TagName("td"));

                    // Get the column data
                    code.Add(col[0].Text);
                    description.Add(col[2].Text);
                    price.Add(col[3].Text);
                }


                // comparing the data to see table has it or not
                for (int i = 0; i < code.Count; i++)
                {
                    if ("(1234)".Equals(code[i]) && "This is is demo".Equals(description[i]) && price[i].Contains("9,990"))
                    {
                        Console.WriteLine("Data is saved Successfully!!!!");
                    }
                    else
                    {
                        Console.WriteLine("Data is not saved Successfully!!!!" + code[i] + " " + price[i].Contains("9,990"));
                    }

                }
            }
        }

        // Select the Drop Down List

        public void dropDownList()
        {
            // this is xpath for the Time item in dropdown list
            string xpath = "//form[@id='TimeMaterialEditForm']" +
                "/following::div[@id='TypeCode-list']/descendant::li[position()=2]";

            // Find the dropdown 
            IWebElement findDropDown = this.driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]"));

            findDropDown.Click();

            // locating the Dropdown values
            IWebElement dropdown = this.driver.FindElement(By.XPath(xpath));
            
            dropdown.Click();

            Console.WriteLine("Dropr down value "+ dropdown.Text);
        }
    }
}
