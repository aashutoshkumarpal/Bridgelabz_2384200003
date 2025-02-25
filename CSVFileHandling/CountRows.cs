using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSVFileHandling
{
    internal class CountRows
    {
        string file = "\"C:\\Users\\91870\\Desktop\\Data.csv\"";

        public void ReadFile(string file)
        {
            try
            {
                string[] lines = File.ReadAllLines(file);

                Console.WriteLine($"Number of Rows (excluding Heading) {lines.Length -1}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }


    }
}

