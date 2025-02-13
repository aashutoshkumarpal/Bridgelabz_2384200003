using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingWindowMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SlidingWindowMax solver = new SlidingWindowMax();
            int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;
            int[] result = solver.FindMaxSlidingWindow(arr, k);

            Console.WriteLine("Sliding Window Maximum: " + string.Join(", ", result));
        }
    }
}
