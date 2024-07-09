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
    public class Validlogin : AutomationWrapper
    {
        [Test]
        [TestCaseSource(typeof(DataSource), nameof(DataSource.ValidLoginData))]
        public void ValidLoginTest(string username, string password, string expectedTitle)
        {
            //driver.FindElement(By.Id("authUser")).SendKeys(username);
            LoginUI login = new LoginUI(driver);
            login.EnterUsername(username);
            login.EnterPassword(password);
            login.ClickOnLogin();

            string actualTitle = driver.Title;
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }
    }
}
