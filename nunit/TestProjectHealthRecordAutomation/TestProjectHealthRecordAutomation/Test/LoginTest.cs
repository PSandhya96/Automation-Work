using KPMG.TestProjectHealthRecordAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Data;
using TestProjectHealthRecordAutomation.Utilities;
using TestProjectHealthRecordAutomation.Pages;

namespace KPMG.TestProjectHealthRecordAutomation.Test
{
    public class LoginTest : AutomationWrapper
    {
        [Test]
        [TestCaseSource(typeof(DataSource), nameof(DataSource.ValidLoginData))]
        public void ValidLoginTest(string username, string password, string expectedTitle)
        {
            //driver.FindElement(By.Id("authUser")).SendKeys(username);
            LoginPage login = new LoginPage(driver);
            login.EnterUsername(username);
            login.EnterPassword(password);
            login.ClickOnLogin();

            string actualTitle = driver.Title;
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }
        [Test]
        public void InvalidLoginTest1()
        {
            //driver.FindElement(By.Id("authUser")).SendKeys("admin1");
            // driver.FindElement(By.Id("clearPass")).SendKeys("pass1");

            //driver.FindElement(By.Id("login-button")).Click();
            LoginPage login = new LoginPage(driver);
            login.EnterUsername("admin1");
            login.EnterPassword("pass");
            login.ClickOnLogin();
            string actualError = driver.FindElement(By.XPath("//p[contains(text(),'Invalid')]")).Text;
            Assert.That(actualError, Is.EqualTo("Invalid username or password"));




        }

    }


}
