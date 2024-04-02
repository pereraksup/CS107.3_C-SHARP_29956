using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_sheet_03_Q2
{
    internal class program
    {

        static void Main(string[] args)
        {
            Employee employee = new Employee(101, "Jhon Doe", 50000);

            Console.WriteLine("Employee information:");
            employee.DisplayEmployeeInfo();

            Console.WriteLine($"Employee ID: {employee.EmployeeID}");

            employee.FullName = "Jane Smith"; //update fullname
            Console.WriteLine($"Updated Full Name: {employee.FullName}");

            //Attempt to modify the salary directly from external code
            //This will work because the salary property has a public
            //setter
            employee.Salary = 55000;
            Console.WriteLine($"Updated Salary: ${employee.Salary}");

            Console.ReadLine();
        }

    }

}
