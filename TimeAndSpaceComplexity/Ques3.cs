using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAndSpaceComplexity
{
    internal class Ques3
    {
        public void InputMethod()
        {
            int[] operationCounts = { 1000, 10000, 1000000 };

            foreach (int count in operationCounts)
            {
                Console.WriteLine($"\nOperations Count: {count}");

                // Measure performance of string concatenation
                Stopwatch sw = Stopwatch.StartNew();
                StringConcatenation(count);
                sw.Stop();
                Console.WriteLine($"String (Immutable) Time: {sw.Elapsed.TotalMilliseconds} ms");

                // Measure performance of StringBuilder
                sw.Restart();
                StringBuilderConcatenation(count);
                sw.Stop();
                Console.WriteLine($"StringBuilder (Mutable) Time: {sw.Elapsed.TotalMilliseconds} ms");
            }
        }

        // String Concatenation (O(N²))
        static void StringConcatenation(int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += "a";  // Creates a new object each time
            }
        }

        // StringBuilder Concatenation (O(N))
        static void StringBuilderConcatenation(int count)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append("a");  // Modifies the existing object
            }
        }
    }
}
