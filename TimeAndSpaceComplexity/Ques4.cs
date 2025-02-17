using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAndSpaceComplexity
{
    internal class Ques4
    {
        public void InputMethod()
        {
            string filePath = "largefile.txt"; // Ensure this file exists (500MB)

            Console.WriteLine("\nReading with StreamReader:");
            MeasurePerformance(() => ReadWithStreamReader(filePath));

            Console.WriteLine("\nReading with FileStream:");
            MeasurePerformance(() => ReadWithFileStream(filePath));
        }

        // Measures execution time
        static void MeasurePerformance(Action fileReadMethod)
        {
            Stopwatch sw = Stopwatch.StartNew();
            fileReadMethod();
            sw.Stop();
            Console.WriteLine($"Time Taken: {sw.Elapsed.TotalSeconds} seconds");
        }

        // Method 1: Reading with StreamReader (Character-based)
        static void ReadWithStreamReader(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.Read() != -1) { }  // Reads character by character
            }
        }

        // Method 2: Reading with FileStream (Byte-based)
        static void ReadWithFileStream(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[4096]; // Read in 4KB chunks
                while (fs.Read(buffer, 0, buffer.Length) > 0) { }
            }
        }
    }
}
