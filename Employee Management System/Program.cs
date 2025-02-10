using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            FullTimeEmployee fte = new FullTimeEmployee(1, "Alice", 50000);
            fte.AssignDepartment("HR");

            PartTimeEmployee pte = new PartTimeEmployee(2, "Bob", 200, 20);
            pte.AssignDepartment("IT");

            employees.Add(fte);
            employees.Add(pte);

            foreach (var emp in employees)
            {
                emp.DisplayDetails();
                if (emp is IDepartment deptEmp)
                {
                    Console.WriteLine(deptEmp.GetDepartmentDetails());
                }
                Console.WriteLine();
            }
        }
    }
}
