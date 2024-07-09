using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPMG.NasscomTesting.Base
{
    public class AutomationWrapper
    {
        public IWebDriver driver;
        [SetUp]
        public void BeforeMethod()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("https://www.nasscom.in/");
        }

        [TearDown]
        public void Aftermethod()
        {
            driver.Quit();
        }
    }
}
