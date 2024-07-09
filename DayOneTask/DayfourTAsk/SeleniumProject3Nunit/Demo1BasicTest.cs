using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KPMG.SeleniumProject3Nunit
{
    public class Demo1BasicTest
    {
        private const string V = "UserTitle";

        [Test]

        public void SalesForceSignUpTest()
        {
            IWebDriver obj = new ChromeDriver();
            obj.Manage().Window.Maximize();
            obj.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            obj.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/?d=70130000000Enyk";

            obj.FindElement(By.Name("UserFirstName")).SendKeys("Siri");
            obj.FindElement(By.Name("UserLastName")).SendKeys("Bharadwaj");
            SelectElement selecttitle = new SelectElement(obj.FindElement(By.Name ("UserTitle")));
            selecttitle.SelectByValue("IT_Manager_AP");


        }
        [Test]
        public void FBRegister()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "http://www.facebook.com/";

            driver.FindElement(By.LinkText("Sign up for Facebook")).Click();
            driver.FindElement(By.Name("firstname")).SendKeys("Pranesh");
            driver.FindElement(By.Name("lastname")).SendKeys("Bharadwaj");

            driver.FindElement(By.Name("reg_email__")).SendKeys("Govinda@123");
            driver.FindElement(By.Id("password_step_input")).SendKeys("hello123");
            driver.FindElement(By.XPath("//input[@value ='2']")).Click();

            //23 oct 2003
            SelectElement selectDay = new SelectElement(driver.FindElement(By.Id("day")));
            selectDay.SelectByText("20");

            SelectElement selectMonth = new SelectElement(driver.FindElement(By.Id("month")));
            selectMonth.SelectByText("Oct");

            SelectElement selectYear = new SelectElement(driver.FindElement(By.Id("year")));
            selectYear.SelectByText("2003");
            driver.FindElement(By.Name("websubmit")).Click();














        }

    }
}

