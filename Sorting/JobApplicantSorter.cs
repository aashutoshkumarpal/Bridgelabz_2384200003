using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class JobApplicantSorter
    {
        public void InputMethod()
        {
            Console.Write("Enter the number of job applicants: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] salaries = new double[n];

            Console.WriteLine("Enter expected salary demands:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Salary {i + 1}: ");
                salaries[i] = Convert.ToDouble(Console.ReadLine());
            }

            HeapSort(salaries);
            DisplaySortedSalaries(salaries);
        }

        // Heap Sort method
        private void HeapSort(double[] arr)
        {
            int n = arr.Length;

            // Build Max Heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            // Extract elements from heap one by one
            for (int i = n - 1; i > 0; i--)
            {
                Swap(arr, 0, i); // Move current root to end
                Heapify(arr, i, 0); // Reheapify the reduced heap
            }
        }

        // Heapify method to maintain heap property
        private void Heapify(double[] arr, int n, int i)
        {
            int largest = i; // Initialize largest as root
            int left = 2 * i + 1; // Left child
            int right = 2 * i + 2; // Right child

            // Check if left child is larger than root
            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }

            // Check if right child is larger than largest so far
            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }

            // If largest is not root, swap and continue heapifying
            if (largest != i)
            {
                Swap(arr, i, largest);
                Heapify(arr, n, largest);
            }
        }

        // Swap method to swap two elements
        private void Swap(double[] arr, int a, int b)
        {
            double temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        // Method to display sorted salary demands
        private void DisplaySortedSalaries(double[] arr)
        {
            Console.WriteLine("\nSorted Salary Demands:");
            foreach (double salary in arr)
            {
                Console.Write(salary + " ");
            }
            Console.WriteLine();
        }
    }
}
