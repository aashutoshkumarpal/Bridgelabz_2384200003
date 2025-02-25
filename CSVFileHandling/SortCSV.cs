using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFileHandling
{
    internal class SortCSV
    {
        // Specify the path to your CSV file
        string file = @"C:\Users\91870\Desktop\employees.csv";

        public void SortAndPrintTopEmployees()
        {
            try
            {
                List<Employee> employees = new List<Employee>();

                using (StreamReader reader = new StreamReader(file))
                {
                    // Read the header line
                    string headerLine = reader.ReadLine();

                    // Loop through each line in the CSV file
                    while (!reader.EndOfStream)
                    {
                        // Read the next line
                        string line = reader.ReadLine();

                        // Split the line into columns
                        string[] columns = line.Split(',');

                        // Create an Employee object and add it to the list
                        if (int.TryParse(columns[0], out int id) &&
                            decimal.TryParse(columns[3], out decimal salary))
                        {
                            Employee employee = new Employee
                            {
                                ID = id,
                                Name = columns[1],
                                Department = columns[2],
                                Salary = salary
                            };
                            employees.Add(employee);
                        }
                    }
                }

                // Sort employees by Salary in descending order and take the top 5
                var topEmployees = employees.OrderByDescending(e => e.Salary).Take(5);

                // Print the top 5 highest-paid employees
                Console.WriteLine("Top 5 Highest-Paid Employees:");
                Console.WriteLine("ID\tName\t\tDepartment\tSalary");
                Console.WriteLine("---------------------------------------------");
                foreach (var emp in topEmployees)
                {
                    Console.WriteLine($"{emp.ID}\t{emp.Name}\t{emp.Department}\t{emp.Salary:F2}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        // Employee class to hold employee data
        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public decimal Salary { get; set; }
        }
    }
}
