using KPMG.NasscomTesting.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasscomTesting.Tests
{
    public class Test1 : AutomationWrapper
    {

        [Test]
        public static void LoginTest()
        {
            driver.FindElement(By.Id("myloginBtn")).click();

            driver.FindElement(By.xPath("//a[@LinkText='Register']")).click();

            driver.FindElement(By.Id("edit-field-fname-reg-0-value")).sendKys("admin");

            driver.FindElement(By.Id("edit-field-lname-reg-0-value")).sendKys("pass");

            driver.FindElement(By.Id("edit-mail")).sendKys("admin@gmail.com");
            
            driver.FindElement(By.Id("edit-field-company-name-registration-0-value")).sendKys("Google");

            SelectElement selectBusiness = new SelectElement(driver.FindElement(By.Id("edit-field-business-focus-reg")));
            selectBusiness.SelectByText("IT Consulting");

            driver.FindElement(By.Id("edit-submit")).Click();

        }
    }
}
