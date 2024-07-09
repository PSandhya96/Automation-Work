using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Project_1
{
    public class Runner_1
    {
        public static void Main(string[] args)
        {
            IWebDriver obj = new EdgeDriver();
            obj.Url = "http://google.com";

            Console.WriteLine(obj.Title);

            obj.Quit();
        }
    }
}
