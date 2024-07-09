using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Pages;
using KPMG.Assignment.Base;
using Assignment.Utilities;

namespace Assignment.Tests
{
    public class InvalidloginTest : AutomationWrapper
    {
        [Test]
        [TestCaseSource(typeof(DataSource), nameof(DataSource.InvalidLoginData))]
        public void InvalidLoginTest(string username, string password)
        {
            //driver.FindElement(By.Id("authUser")).SendKeys(username);
            LoginUI login = new LoginUI(driver);
            login.EnterUsername(username);
            login.EnterPassword(password);
            login.ClickOnLogin();

           
        }
    }
}
