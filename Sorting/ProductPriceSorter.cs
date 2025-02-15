using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class ProductPriceSorter
    {
        public void InputMethod()
        {
            Console.Write("Enter the number of product prices: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] prices = new double[n];

            Console.WriteLine("Enter product prices:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Price {i + 1}: ");
                prices[i] = Convert.ToDouble(Console.ReadLine());
            }

            QuickSort(prices, 0, n - 1);
            DisplaySortedPrices(prices);
        }

        // Quick Sort method
        private void QuickSort(double[] arr, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(arr, low, high);
                QuickSort(arr, low, partitionIndex - 1);  // Sort left part
                QuickSort(arr, partitionIndex + 1, high); // Sort right part
            }
        }

        // Partition method for Quick Sort
        private int Partition(double[] arr, int low, int high)
        {
            double pivot = arr[high]; // Choosing the last element as pivot
            int i = low - 1; // Index for smaller elements

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot) // If current element is smaller than pivot
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, high); // Move pivot to the correct position
            return i + 1;
        }

        // Swap method to swap two elements
        private void Swap(double[] arr, int a, int b)
        {
            double temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        // Method to display sorted product prices
        private void DisplaySortedPrices(double[] arr)
        {
            Console.WriteLine("\nSorted Product Prices:");
            foreach (double price in arr)
            {
                Console.Write(price + " ");
            }
            Console.WriteLine();
        }
    }
}
