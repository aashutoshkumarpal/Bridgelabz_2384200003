using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecptionHandlingAssignment
{
    internal class FileHandler
    {
        public void ReadFile()
        {
            string file = "Data.txt";

            try
            {
                if (!File.Exists(file))
                {
                    throw new FileNotFoundException();
                }
                string content = File.ReadAllText(file);
                Console.WriteLine("File Contents:\n" + content);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: The file 'Data.txt' was not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
            }
        }
    }
}
