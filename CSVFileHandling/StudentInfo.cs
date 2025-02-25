using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFileHandling
{
    public class StudentInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program3
    {
        static void Main(string[] args)
        {
            string students1FilePath = @"C:\Users\91870\Desktop\students1.csv"; // Update the path as needed
            string students2FilePath = @"C:\Users\91870\Desktop\students2.csv"; // Update the path as needed
            string mergedFilePath = @"C:\Users\91870\Desktop\merged_students.csv"; // Output file path

            // Dictionary to hold student data from the first file
            Dictionary<int, StudentInfo> studentInfoDict = new Dictionary<int, StudentInfo>();

            // Read the first CSV file
            try
            {
                using (StreamReader reader = new StreamReader(students1FilePath))
                {
                    // Read the header line
                    string headerLine = reader.ReadLine();

                    // Loop through each line in the first CSV file
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(',');

                        int id = int.Parse(values[0]);
                        string name = values[1];
                        int age = int.Parse(values[2]);

                        // Store the student info in the dictionary
                        studentInfoDict[id] = new StudentInfo { ID = id, Name = name, Age = age };
                    }
                }

                // Read the second CSV file and merge data
                using (StreamReader reader = new StreamReader(students2FilePath))
                using (StreamWriter writer = new StreamWriter(mergedFilePath))
                {
                    // Write the header for the merged file
                    writer.WriteLine("ID,Name,Age,Marks,Grade");

                    // Read the header line
                    string headerLine = reader.ReadLine();

                    // Loop through each line in the second CSV file
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(',');

                        int id = int.Parse(values[0]);
                        int marks = int.Parse(values[1]);
                        string grade = values[2];

                        // Check if the ID exists in the first file's dictionary
                        if (studentInfoDict.TryGetValue(id, out StudentInfo studentInfo))
                        {
                            // Write the merged data to the new file
                            writer.WriteLine($"{studentInfo.ID},{studentInfo.Name},{studentInfo.Age},{marks},{grade}");
                        }
                    }
                }

                Console.WriteLine("CSV files merged successfully into " + mergedFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}