using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_sheet_03_Q2
{ 
    public class Employee
{
    public int employeeID;
    public string fullName;
    public double salary;


    public Employee(int employeeID, string fullName, double salary)
    {
        this.employeeID = employeeID;
        this.fullName = fullName;
        this.salary = salary;
    }

    public int EmployeeID
    {
        get => employeeID;
        set => employeeID = value;
    }

    public string FullName
    {
        get => fullName;
        set => fullName = value;

    }


    public double Salary
    {
        get => salary;
        set => salary = value;
    }

    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"Employee ID: {employeeID}");
        Console.WriteLine($"Full Name: {fullName}");
        Console.WriteLine($"Salary: {salary}");
    }
}

}