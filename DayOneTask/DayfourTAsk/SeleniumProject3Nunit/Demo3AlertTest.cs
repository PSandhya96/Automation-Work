using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.DevTools.V124.Tethering;

namespace SeleniumProject3Nunit
{
    public class Demo3AlertTest
    {
        [Test]
        public void AlertDemoTest()
        {


            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";
            driver.FindElement(By.XPath("//img[@alt = 'Go']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(X=>X.SwitchTo().Alert());
            string actualAlertText = driver.SwitchTo().Alert().Text;
            Console.WriteLine(actualAlertText);
            driver.SwitchTo().Alert().Accept();







        }
    }
}
