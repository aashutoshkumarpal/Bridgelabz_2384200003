using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOPs
{
    abstract class Employee
    {

        private int employeeId;
        private string name;
        private double baseSalary;

        public int EmployeeId
        {
            get { return employeeId; } set { employeeId = value; }
        }  

        public string Name
        {
            get { return name; } set { name = value; } 
        }

        public double BaseSalary
        {
            get { return baseSalary; } set { baseSalary = value; } 
        }

        public Employee(int id, string name, double baseSalary)
        { 
            this.employeeId = id;
            this.name = name;
            this.baseSalary = baseSalary;   
        }

        public abstract double CalculateSalary();

        public void DisplayDetails()
        {
            Console.WriteLine($"ID : {employeeId}, Name : {name}, Salary :{CalculateSalary():c}");
        }
    }

    interface IDepartment
    {
        void AssignDepartment(string department);

        string GetDepartmentDetails();
    }

    class FullTimeEmployee : Employee, IDepartment
    {

        private string department;

        public FullTimeEmployee(int id, string name, double salary) : base(id, name, salary) { }


        public void AssignDepartment(string department)
        {
            this.department = department;
        }

        public override double CalculateSalary()
        {
            return BaseSalary;
        }

        public string GetDepartmentDetails()
        {
           return $"Department: {department}";
        }
    }

    class PartTimeEmployee : Employee, IDepartment
    {

        private int hoursWorked;
        private double hourlyRate;
        private string department;
        public void AssignDepartment(string department)
        {
            this.department = department;
        }

        public PartTimeEmployee(int id, string name, double hourlyRate, int hoursWorked)
        : base(id, name, hourlyRate * hoursWorked)
        {
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;
        }


        public override double CalculateSalary()
        {
            return hourlyRate* hoursWorked;
        }

        public string GetDepartmentDetails()
        {
            return $"Department :{department}";
        }
    }
}
