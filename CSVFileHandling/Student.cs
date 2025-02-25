using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;

namespace CSVFileHandling
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }

        public override string ToString()
        {
            return $"Student{{ID={ID}, Name='{Name}', Age={Age}, Marks={Marks}}}";
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            string csvFilePath = @"C:\Users\91870\Desktop\students.csv"; // Update path if needed

            try
            {
                if (!File.Exists(csvFilePath))
                {
                    Console.WriteLine("Error: CSV file not found.");
                    return;
                }

                using (var reader = new StreamReader(csvFilePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    List<Student> students = new List<Student>(csv.GetRecords<Student>());

                    if (students.Count > 0)
                    {
                        Console.WriteLine("Students List:");
                        foreach (Student student in students)
                        {
                            Console.WriteLine(student);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No valid student data found.");
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
