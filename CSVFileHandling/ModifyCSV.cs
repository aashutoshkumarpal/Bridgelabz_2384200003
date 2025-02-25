using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSVFileHandling
{
    internal class ModifyCSV
    {
        // Specify the path to your original CSV file and the new CSV file
        string inputFile = @"C:\Users\91870\Desktop\employees.csv";
        string outputFile = @"C:\Users\91870\Desktop\updated_employees.csv";

        public void UpdateSalaries()
        {
            try
            {
                using (StreamReader reader = new StreamReader(inputFile))
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    // Read the header line and write it to the new file
                    string headerLine = reader.ReadLine();
                    writer.WriteLine(headerLine); // Write header to the new file

                    // Loop through each line in the original CSV file
                    while (!reader.EndOfStream)
                    {
                        // Read the next line
                        string line = reader.ReadLine();

                        // Split the line into columns
                        string[] columns = line.Split(',');

                        // Check if the Department is "IT"
                        if (columns[2].Equals("IT", StringComparison.OrdinalIgnoreCase))
                        {
                            // Increase the salary by 10%
                            if (decimal.TryParse(columns[3], out decimal salary))
                            {
                                salary *= 1.10m; // Increase salary by 10%
                                columns[3] = salary.ToString("F2"); // Update the salary column
                            }
                        }

                        // Write the updated or original line to the new file
                        writer.WriteLine(string.Join(",", columns));
                    }
                }

                Console.WriteLine("Salaries updated and saved to the new CSV file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
