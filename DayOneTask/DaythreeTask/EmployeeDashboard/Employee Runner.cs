using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard
{
    public class Employee_Runner
    {
        public static void Main(string[] args)
        {
            Employee.companyname = "KPMG";
            Employee emp1 = new Employee();
            Employee emp2 = new Employee(); 
            Employee emp3 = new Employee();
            //load 1st employee details
            // emp1.empID = 101;
            emp1.EmpID = 99;
            emp1.empName = "Pranesh";
            emp1.empSalary = 9000;

            //LOAD 2ND EMPLOYEE DETAILS
            //emp2.empID = 102;
            emp2.EmpID = 102;
            emp2.empName = "Lakshmi";
            emp2.empSalary = 7000;

            //LOAD 2ND EMPLOYEE DETAILS
            //emp3.empID = 103;
            emp3.EmpID = 155;
            emp3.empName = "AmithVikram";
            emp3.empSalary = 6000;
            
            emp1.PrintEmployeeDetails();
            emp2.PrintEmployeeDetails();
            emp3.PrintEmployeeDetails();

            Employee.EmployeeGreetings(emp1);
            Employee.EmployeeGreetings(emp2);
            Employee.EmployeeGreetings(emp3);

            String output= Employee.GetEmployeeGreetings(emp1);
            Console.WriteLine(output);

            output = Employee.GetEmployeeGreetings(emp2);
            Console.WriteLine(output);

            output = Employee.GetEmployeeGreetings(emp3);
            Console.WriteLine(output);


        }
    }
}
