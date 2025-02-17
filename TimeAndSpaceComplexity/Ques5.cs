using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAndSpaceComplexity
{
    internal class Ques5
    {
        public  void InputMethod()
        {
            int[] testCases = { 10, 30, 50 };

            foreach (int n in testCases)
            {
                Console.WriteLine($"\nFibonacci({n}):");

                // Measure Recursive Fibonacci
                if (n <= 30)  // Prevent freezing for large values
                {
                    MeasurePerformance(() => Console.WriteLine($"Recursive Result: {FibonacciRecursive(n)}"), "Recursive");
                }
                else
                {
                    Console.WriteLine("Recursive: Skipped (Too slow for large N)");
                }

                // Measure Iterative Fibonacci
                MeasurePerformance(() => Console.WriteLine($"Iterative Result: {FibonacciIterative(n)}"), "Iterative");
            }
        }

        // Measure execution time
        static void MeasurePerformance(Action method, string methodName)
        {
            Stopwatch sw = Stopwatch.StartNew();
            method();
            sw.Stop();
            Console.WriteLine($"{methodName} Time: {sw.Elapsed.TotalMilliseconds} ms");
        }

        // Recursive Fibonacci (O(2^N))
        public static int FibonacciRecursive(int n)
        {
            if (n <= 1) return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        // Iterative Fibonacci (O(N))
        public static int FibonacciIterative(int n)
        {
            if (n <= 1) return n;

            int a = 0, b = 1, sum;
            for (int i = 2; i <= n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            return b;
        }
    }
}
