﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using KPMG.TestProjectHealthRecordAutomation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPMG.TestProjectHealthRecordAutomation.Test
{
    public class LoginUITest : AutomationWrapper
    {   
        [Test]
        public void TitleTest()
        {
            string actualTitle = driver.Title;
            Assert.That(actualTitle, Is.EqualTo("OpenEMR Login"));
            
        }

        [Test]

        public void ApplicationDescriptionTest()
        {
            string actualDesc = driver.FindElement(By.XPath("//p[contains(text(),'most')]")).Text;
            Assert.That(actualDesc, Is.EqualTo("The most popular open-source Electronic Health Record and Medical Practice Management solution."));


        }
    }

}
