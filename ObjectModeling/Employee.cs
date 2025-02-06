using System;
using System.Collections.Generic;

namespace ObjectModeling
{
    public class Employee
    {
        public string Name { get; }
        public string Position { get; }

        public Employee(string name, string position)
        {
            Name = name;
            Position = position;
        }

        public void DisplayEmployee()
        {
            Console.WriteLine($"   Employee: {Name}, Position: {Position}");
        }
    }

    public class Department
    {
        public string DepartmentName { get; }
        private List<Employee> employees;

        public Department(string departmentName)
        {
            DepartmentName = departmentName;
            employees = new List<Employee>();
        }

        public void AddEmployee(string name, string position)
        {
            employees.Add(new Employee(name, position));
        }

        public void DisplayDepartment()
        {
            Console.WriteLine($"\nDepartment: {DepartmentName}");
            if (employees.Count == 0)
            {
                Console.WriteLine("   No employees in this department.");
            }
            else
            {
                foreach (var employee in employees)
                {
                    employee.DisplayEmployee();
                }
            }
        }
    }

    public class Company
    {
        public string CompanyName { get; }
        private List<Department> departments;

        public Company(string companyName)
        {
            CompanyName = companyName;
            departments = new List<Department>();
        }

        public void AddDepartment(string departmentName)
        {
            departments.Add(new Department(departmentName));
        }

        public Department GetDepartment(string departmentName)
        {
            return departments.Find(d => d.DepartmentName == departmentName);
        }

        public void DisplayCompany()
        {
            Console.WriteLine($"\nCompany: {CompanyName}");
            if (departments.Count == 0)
            {
                Console.WriteLine("No departments in this company.");
            }
            else
            {
                foreach (var department in departments)
                {
                    department.DisplayDepartment();
                }
            }
        }

        ~Company()
        {
            Console.WriteLine($"Company {CompanyName} is being deleted, along with all departments and employees.");
        }
    }

    public class CompanyDemo
    {
        public void InputMethod()
        {
            // Creating a company
            Company myCompany = new Company("TechCorp");

            // Adding departments
            myCompany.AddDepartment("IT");
            myCompany.AddDepartment("HR");

            // Adding employees to departments
            myCompany.GetDepartment("IT").AddEmployee("Alice", "Software Engineer");
            myCompany.GetDepartment("IT").AddEmployee("Bob", "System Administrator");
            myCompany.GetDepartment("HR").AddEmployee("Charlie", "Recruiter");

            // Display company structure
            myCompany.DisplayCompany();

            // Simulating deletion of the company
            myCompany = null;
            GC.Collect(); // Force garbage collection to demonstrate destructor
        }
    }
}
