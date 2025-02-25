using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFileHandling
{
    internal class FilterRecords
    {
        // Specify the path to your CSV file
        string file = @"C:\Users\91870\Desktop\students.csv";

        public void ReadAndFilterRecords()
        {
            try
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    // Read the header line
                    string headerLine = reader.ReadLine();
                    Console.WriteLine(headerLine); // Print header

                    // Loop through each line in the CSV file
                    while (!reader.EndOfStream)
                    {
                        // Read the next line
                        string line = reader.ReadLine();

                        // Split the line into columns
                        string[] columns = line.Split(',');

                        // Check if the Marks are greater than 80
                        if (int.TryParse(columns[3], out int marks) && marks > 80)
                        {
                            // Print the qualifying record
                            Console.WriteLine(line);
                        }
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
