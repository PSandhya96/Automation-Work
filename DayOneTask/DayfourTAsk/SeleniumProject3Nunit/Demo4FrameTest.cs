using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace SeleniumProject3Nunit
{
    public class Demo4FrameTest
   
    {
        [Test]
        public void DemoFrameTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";
            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("jack123");
            driver.FindElement(By.Name("flDLoginUser ID")).SendKeys("Ambe");


        }
    }
}
