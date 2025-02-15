using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class StudentAgeSorter
    {
        public void InputMethod()
        {
            Console.Write("Enter the number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ages = new int[n];

            Console.WriteLine("Enter students' ages (between 10 and 18):");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Age {i + 1}: ");
                ages[i] = Convert.ToInt32(Console.ReadLine());

                // Validate input
                if (ages[i] < 10 || ages[i] > 18)
                {
                    Console.WriteLine("Invalid age! Enter an age between 10 and 18.");
                    i--; // Re-enter the age
                }
            }

            CountingSort(ages);
            DisplaySortedAges(ages);
        }

        // Counting Sort method
        private void CountingSort(int[] arr)
        {
            int minAge = 10, maxAge = 18;
            int range = maxAge - minAge + 1;

            int[] count = new int[range];
            int[] output = new int[arr.Length];

            // Count occurrences of each age
            foreach (int age in arr)
            {
                count[age - minAge]++;
            }

            // Compute cumulative count
            for (int i = 1; i < range; i++)
            {
                count[i] += count[i - 1];
            }

            // Build the sorted output array
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                output[count[arr[i] - minAge] - 1] = arr[i];
                count[arr[i] - minAge]--;
            }

            // Copy the sorted array back to the original array
            Array.Copy(output, arr, arr.Length);
        }

        // Method to display sorted student ages
        private void DisplaySortedAges(int[] arr)
        {
            Console.WriteLine("\nSorted Student Ages:");
            foreach (int age in arr)
            {
                Console.Write(age + " ");
            }
            Console.WriteLine();
        }
    }
}
