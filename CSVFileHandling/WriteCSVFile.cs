using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSVFileHandling
{
    internal class WriteCSVFile
    {
        String fileName = @"C:\Users\91870\Desktop\New folder (3)\FileHandling\Employee.csv";

        public void writeFile(String fileName)
        {
            try
            {
               using(StreamWriter writer = new StreamWriter(fileName) )
                {
                    writer.WriteLine("ID, Name, Department, Salary");

                    Console.Write("How many employees do you want to enter? ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    for (int i = 0; i < numberOfEmployees; i++)
                    {
                        Console.WriteLine($"\nEntering details for Employee {i + 1}:");

                        Console.Write("Enter ID: ");
                        string id = Console.ReadLine();

                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Department: ");
                        string department = Console.ReadLine();

                        Console.Write("Enter Salary: ");
                        string salary = Console.ReadLine();

                        writer.WriteLine($"{id}, {name}, {department}, {salary}");
                    }

                    Console.WriteLine("\nEmployee details written to CSV file successfully.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        } 
    }
}
