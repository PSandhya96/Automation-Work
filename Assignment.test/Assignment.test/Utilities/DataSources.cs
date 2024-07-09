using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Utilities
{
    public class DataSource
    {
        public static object[] ValidLoginData()
        {
            object[] dataset1 = new object[3];
            dataset1[0] = "Admin";
            dataset1[1] = "admin123";
            dataset1[2] = "OrangeHRM";

            
            object[] allData = new object[1];
            allData[0] = dataset1;
            
            return allData;
        }

        public static object[] InvalidLoginData()
        {
            object[] dataset1 = new object[2];
            dataset1[0] = "John";
            dataset1[1] = "admin123";
           

            object[] dataset2 = new object[2];
            dataset2[0] = "Peter";
            dataset2[1] = "admin123";
            


            object[] allData = new object[2];
            allData[0] = dataset1;
            allData[1] = dataset2;

            return allData;
        }
    }
}
