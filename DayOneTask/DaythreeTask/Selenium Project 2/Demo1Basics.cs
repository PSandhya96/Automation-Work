using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Project_2
{
    public class Demo1Basics
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";

            string actualTitle = driver.Title;
            Console.Write(actualTitle);
            Console.WriteLine(driver.Title);
            Console.WriteLine(driver.Url);

            Console.WriteLine(driver.PageSource);

            driver.FindElement(By.Id("email")).SendKeys("siri999@gmail.com");

            driver.FindElement(By.Id("pass")).SendKeys("welcome123");


            driver.FindElement(By.Name("login")).Click();


        }

    }
}
