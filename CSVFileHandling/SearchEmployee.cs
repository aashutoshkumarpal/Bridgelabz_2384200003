using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFileHandling
{
    internal class SearchEmployee
    {
        string file = @"C:\Users\91870\Desktop\students.csv";

        public void Search(string employeeName)
        {
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string Heading = sr.ReadLine();
                    Console.WriteLine(Heading);

                    bool found = false;

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] column = line.Split(',');

                        if (column[1].Equals(employeeName, StringComparison.OrdinalIgnoreCase))
                        {
                            // Print the department and salary
                            Console.WriteLine($"Department: {column[2]}");
                            Console.WriteLine($"Salary: {column[3]}");
                            found = true;
                            break;

                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Employee not found.");
                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
