using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject3Nunit
{
    public class Demo2Tabs
    {
        [Test]
        public void Demo1MultipleTabs()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.db4free.net/";
            driver.FindElement(By.PartialLinkText("phpMyAdmin")).Click();

            IWebDriver webDriver = driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.Id("input_username")).SendKeys("admin");
            driver.FindElement(By.Id("input_password")).SendKeys("admin123");
            driver.FindElement(By.Id("input_go")).Click();
            driver.Close();
            //switch to 1st tab
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Console.WriteLine(driver.Title);
            
            
        }

        [Test]

        public void CitibankTabs()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "https://www.online.citibank.co.in/";
            driver.FindElement(By.ClassName("newclose")).Click();
            driver.FindElement(By.ClassName("newclose2")).Click();
            driver.FindElement(By.Id("loginId")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.XPath("//div[contains(text(),'Forgot User ID?')]")).Click();
            driver.FindElement(By.LinkText("select your product type")).Click();
            driver.FindElement(By.LinkText("Credit Card")).Click();
            driver.FindElement(By.Id("citiCard1")).SendKeys("1234");

            driver.FindElement(By.Id("citiCard2")).SendKeys("5656");

            driver.FindElement(By.Id("citiCard3")).SendKeys("8887");

            driver.FindElement(By.Id("citiCard4")).SendKeys("9998");
            //driver.FindElement(By.CssSelector('#citicard1")).SendKeys("3334");
            driver.FindElement(By.CssSelector("input[name='citiCard2']")).SendKeys("5555");

            driver.FindElement(By.Id("cvvnumber")).SendKeys("876");

            driver.FindElement(By.Id("bill-date-long")).Click();
            SelectElement selectYear = new SelectElement(driver.FindElement(By.XPath("//select[@data-handler='selectYear']")));
            selectYear.SelectByText("2022");
            SelectElement selectMonth = new SelectElement(driver.FindElement(By.XPath("//select[@data-handler='selectMonth']")));
            selectMonth.SelectByValue("11");
            driver.FindElement(By.LinkText("9")).Click();

            string actualValue=driver.FindElement(By.XPath("//b[contains(text(),'One Time')]")).Text;
            string actualValue1 = driver.FindElement(By.XPath("//div[@role= 'dialog']")).Text;
            Console.WriteLine(actualValue);
            Console.WriteLine(actualValue1);







        }
    }
}
