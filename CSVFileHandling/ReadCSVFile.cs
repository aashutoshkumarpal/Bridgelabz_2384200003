using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSVFileHandling
{
    internal class ReadCSVFile
    {
        string file  = "\"C:\\Users\\91870\\Desktop\\Data.csv\"";

        public void ReadFile(string file)
        {
            try
            {
                string[] lines = File.ReadAllLines(file);

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] columns = lines[i].Split(',');

                    Console.WriteLine($"ID: {columns[0]}");
                    Console.WriteLine($"Name: {columns[1]}");
                    Console.WriteLine($"Age: {columns[2]}");
                    Console.WriteLine($"Marks: {columns[3]}");
                    Console.WriteLine(new string('-', 20));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
           
        }

       
    }
}
