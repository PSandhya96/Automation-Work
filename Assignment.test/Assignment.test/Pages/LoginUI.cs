using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Pages
{
    public class LoginUI
    {
        private IWebDriver driver;

        public LoginUI(IWebDriver driver)
        {

            this.driver = driver;
        }

        public void EnterUsername(string username)
        {
            driver.FindElement(By.Name("username")).SendKeys(username);
        }
        public void EnterPassword(string password)
        {
            driver.FindElement(By.Name("password")).SendKeys(password);
        }
        //ClickOnLogin

        public void ClickOnLogin()
        {
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[3]/button")).Click();
        }
        public string GetInvalidErrorMessage()
        {
            return driver.FindElement(By.XPath("//p[contains(text(),'Invalid')]")).Text;

        }

    }
}
