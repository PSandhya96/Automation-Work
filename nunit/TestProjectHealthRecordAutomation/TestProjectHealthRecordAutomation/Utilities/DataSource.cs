using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectHealthRecordAutomation.Utilities
{
    public class DataSource
    {




        public static object[] ValidLoginData()
        {
            object[] dataset1 = new object[3];
            dataset1[0] = "admin";
            dataset1[1] = "pass";
            dataset1[2] = "OpenEMR";

            object[] dataset2 = new string[3];
            dataset2[0] = "physician";
            dataset2[1] = "physician";
            dataset2[2] = "OpenEMR";

            object[] allData = new object[2];
            allData[0] = dataset1;
            allData[1] = dataset2;

            return allData;
        }

    }
}
