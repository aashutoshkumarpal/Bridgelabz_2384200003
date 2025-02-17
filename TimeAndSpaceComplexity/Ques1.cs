using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAndSpaceComplexity
{
    internal class Ques1
    {
        public void InputMethod()
        {
            int[] datasetSizes = { 1000, 10000, 1000000 };
            Random rand = new Random();

            foreach (int size in datasetSizes)
            {
                int[] data = GenerateRandomArray(size);
                int target = data[rand.Next(size)]; // Select a random target from the dataset

                Console.WriteLine($"\nDataset Size: {size}");

                // Measure Linear Search Time
                Stopwatch sw = Stopwatch.StartNew();
                int linearIndex = LinearSearch(data, target);
                sw.Stop();
                Console.WriteLine($"Linear Search Time: {sw.Elapsed.TotalMilliseconds} ms");

                // Measure Binary Search Time (after sorting)
                Array.Sort(data);
                sw.Restart();
                int binaryIndex = BinarySearch(data, target);
                sw.Stop();
                Console.WriteLine($"Binary Search Time: {sw.Elapsed.TotalMilliseconds} ms");
            }
        }

        // Generate Random Array
        static int[] GenerateRandomArray(int size)
        {
            Random rand = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(1, size * 10);
            }
            return arr;
        }

        // Linear Search (O(N))
        static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }
            return -1; // Not found
        }

        // Binary Search (O(log N))
        static int BinarySearch(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1; // Not found
        }
    }
}
