using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class EmployeeIDSorter
    {
        // Method to take user input
        public void InputMethod()
        {
            Console.Write("Enter the number of employees: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] employeeIDs = new int[n];

            Console.WriteLine("Enter employee IDs:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"ID {i + 1}: ");
                employeeIDs[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Sorting employee IDs using Insertion Sort
            InsertionSort(employeeIDs);

            // Displaying the sorted IDs
            DisplaySortedIDs(employeeIDs);
        }

        // Method to perform Insertion Sort
        private void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];  // Store the current element
                int j = i - 1;

                // Move elements of the sorted part that are greater than key
                // one position ahead of their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;  // Insert key at its correct position
            }
        }

        // Method to display sorted employee IDs
        private void DisplaySortedIDs(int[] arr)
        {
            Console.WriteLine("\nSorted Employee IDs:");
            foreach (int id in arr)
            {
                Console.Write(id + " ");
            }
            Console.WriteLine();
        }
    }
}
