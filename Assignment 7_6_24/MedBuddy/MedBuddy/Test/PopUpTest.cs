using KPMG.MedBuddy.Base;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedBuddy.Test
{
    public class PopUpTest : AutomationWrapper
    {
        [Test]
        public void ClosePopUp()
        {
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.ClassName("CT_InterstitialClose")).Click();

        }
        [Test]
        public void LoginTest()
        {
            
            driver.FindElement(By.XPath("//*[@id=\"headerView\"]/div[2]/ul/li[2]/a[2]")).Click();

            //driver.FindElement(By.ClassName("coperate")).Click();

            driver.FindElement(By.XPath("//div[@LinkText='I have a Corporate Account']")).Click();

            driver.FindElement(By.XPath("//a[@LinkText='Learn More']")).Click();

            driver.FindElement(By.XPath("//a[@LinkText='skip']")).Click();

            driver.FindElement(By.XPath("//a[@LinkText='Login using Username & Password']")).Click();

            driver.FindElement(By.Id("username")).SendKeys("Hari");

            driver.FindElement(By.XPath("//button[@LinkText='Proceed']")).Click();

            driver.FindElement(By.Id("password")).SendKeys("Hari@123");

            driver.FindElement(By.XPath("//img[@class='show password']")).Click();

            driver.FindElement(By.XPath("//button[@LinkText='Sign In']")).Click();

            String errorText = driver.FindElement(By.XPath("//div[@class='errorTxt']")).Text;

            Console.WriteLine("Error Text : " + errorText);
        }
    }
}
