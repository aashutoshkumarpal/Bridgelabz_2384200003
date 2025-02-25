using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFileHandling
{
    public class LargeCSVReader
    {
        public void InputMethod()
        {
            string csvFilePath = @"C:\Users\91870\Desktop\largefile.csv"; // Update the path as needed
            int chunkSize = 100; // Number of lines to process at a time
            int totalRecordsProcessed = 0;

            try
            {
                using (StreamReader reader = new StreamReader(csvFilePath))
                {
                    string headerLine = reader.ReadLine(); // Read the header line if needed
                    totalRecordsProcessed++; // Count the header line if you want

                    while (!reader.EndOfStream)
                    {
                        int recordsInChunk = 0;

                        // Process a chunk of lines
                        for (int i = 0; i < chunkSize && !reader.EndOfStream; i++)
                        {
                            string line = reader.ReadLine();
                            if (line != null)
                            {
                                // Process the line (for demonstration, we just count it)
                                recordsInChunk++;
                                // You can add your processing logic here
                            }
                        }

                        totalRecordsProcessed += recordsInChunk;
                        Console.WriteLine($"Processed {recordsInChunk} records in this chunk.");
                    }
                }

                Console.WriteLine($"Total records processed: {totalRecordsProcessed}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
