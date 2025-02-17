using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAndSpaceComplexity
{
    internal class Ques2
    {
        public void  InputMethod()
        {
            int[] datasetSizes = { 1000, 10000, 1000000 };
            Random rand = new Random();

            foreach (int size in datasetSizes)
            {
                int[] data = GenerateRandomArray(size);

                Console.WriteLine($"\nDataset Size: {size}");

                // Bubble Sort (Only for small data)
                if (size <= 10000)
                {
                    MeasurePerformance(() => BubbleSort((int[])data.Clone()), "Bubble Sort");
                }

                // Merge Sort
                MeasurePerformance(() => MergeSort((int[])data.Clone()), "Merge Sort");

                // Quick Sort
                MeasurePerformance(() => QuickSort((int[])data.Clone(), 0, size - 1), "Quick Sort");
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

        // Measure execution time
        static void MeasurePerformance(Action sortingMethod, string sortName)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sortingMethod();
            sw.Stop();
            Console.WriteLine($"{sortName} Time: {sw.Elapsed.TotalMilliseconds} ms");
        }

        // Bubble Sort (O(N²))
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap elements
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // Merge Sort (O(N log N))
        static void MergeSort(int[] arr)
        {
            if (arr.Length < 2) return;
            int mid = arr.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[arr.Length - mid];

            Array.Copy(arr, 0, left, 0, mid);
            Array.Copy(arr, mid, right, 0, arr.Length - mid);

            MergeSort(left);
            MergeSort(right);
            Merge(arr, left, right);
        }

        static void Merge(int[] arr, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                arr[k++] = (left[i] <= right[j]) ? left[i++] : right[j++];
            }
            while (i < left.Length) arr[k++] = left[i++];
            while (j < right.Length) arr[k++] = right[j++];
        }

        // Quick Sort (O(N log N))
        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(arr, low, high);
                QuickSort(arr, low, pivot - 1);
                QuickSort(arr, pivot + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
            return i + 1;
        }
    }
}
