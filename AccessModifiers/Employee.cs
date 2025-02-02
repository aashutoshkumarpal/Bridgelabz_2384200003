using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    // Base Class: Employee
    public class Employee
    {
        // Public member: Can be accessed anywhere
        public int EmployeeID { get; set; }

        // Protected member: Can be accessed in derived classes
        protected string Department;

        // Private member: Can only be accessed within the Employee class
        private double Salary;

        // Constructor to initialize employee details
        public Employee(int employeeID, string department, double salary)
        {
            EmployeeID = employeeID;
            Department = department;
            Salary = salary;
        }

        // Public Method to Modify Salary
        public void UpdateSalary(double newSalary)
        {
            if (newSalary > 0)
            {
                Salary = newSalary;
                Console.WriteLine($"Salary updated to ${Salary:F2}");
            }
            else
            {
                Console.WriteLine("Invalid salary amount!");
            }
        }

        // Public Method to Get Salary
        public double GetSalary()
        {
            return Salary;
        }

        // Public Method to Display Employee Details
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Salary: ${Salary:F2}");
            Console.WriteLine();
        }
    }

    // Derived Class: Manager
    public class Manager : Employee
    {
        public string TeamSize { get; set; }

        // Constructor using base class constructor
        public Manager(int employeeID, string department, double salary, string teamSize)
            : base(employeeID, department, salary)
        {
            TeamSize = teamSize;
        }

        // Method to Display Manager Details
        public void DisplayManagerDetails()
        {
            Console.WriteLine($"Manager ID: {EmployeeID}"); 
            Console.WriteLine($"Department: {Department}"); 
            Console.WriteLine($"Salary: ${GetSalary():F2}"); 
            Console.WriteLine($"Managing Team of: {TeamSize} employees");
            Console.WriteLine();
        }
    }
}
