using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard
{
    public class Employee
    {
        private int empID;
        public string empName;
        public double empSalary;
        public static string companyname;
        public int EmpID
        {
            get
            {
                return empID;

            }
            set
            {
                if (value >= 100)
                {
                    empID = value;
                }
                else
                {
                    Console.WriteLine("Invalid id - now id is retained as 0");
                }
            }




        }
        public void PrintEmployeeDetails()
        {
            Console.WriteLine("Employee Id: " + empID);
            Console.WriteLine("Employee Name: " + empName);
            Console.WriteLine("Employee Salary: " + empSalary);
            Console.WriteLine("Company Name: " + Employee.companyname);

        }
        public static void EmployeeGreetings(Employee emp)
        {
            Console.WriteLine("Hello " + emp.empName + " \n Welcome to the " + Employee.companyname);

        }
        public static string GetEmployeeGreetings(Employee emp)
        {

            return ("Hello " + emp.empName + " \n Welcome to the " + Employee.companyname);

        }
    }
}
