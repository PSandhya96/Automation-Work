using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Pages;
using KPMG.Assignment.Base;
using Assignment.Utilities;

namespace Assignment.test.Utilities
{
    public class EmployeeTest : AutomationWrapper
    {
        private IWebDriver driver;

        public EmployeeTest(IWebDriver driver)
        {

            this.driver = driver;
        }

        
        
        
        EmployeeTest login = new EmployeeTest(driver);
        login.EmployeeTest(username);
        driver.FindElement(By.name("username")).SendKeys("Admin");
        Driver.FindElement(By.name("password")).SendKeys("admin123");


        
    }

}
