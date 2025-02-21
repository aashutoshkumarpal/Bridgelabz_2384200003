using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecptionHandlingAssignment
{
    internal class ReadFirstLine
    {
        public void InputMethod()
        {
            string filePath = "info.txt";

            try
            {
                // Using statement to ensure the file is properly closed
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string firstLine = reader.ReadLine();
                    Console.WriteLine("First line of the file: " + firstLine);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error reading file.");
            }
        }
    }
}
