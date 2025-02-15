using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class ExamScoreSorter
    {
        public void InputMethod()
        {
            Console.Write("Enter the number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] scores = new int[n];

            Console.WriteLine("Enter students' exam scores:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Score {i + 1}: ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }

            SelectionSort(scores);
            DisplaySortedScores(scores);
        }

        // Selection Sort method
        private void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i; // Assume the first element is the minimum

                // Find the minimum element in the unsorted part
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap the found minimum element with the first unsorted element
                Swap(arr, i, minIndex);
            }
        }

        // Swap method to swap two elements
        private void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        // Method to display sorted exam scores
        private void DisplaySortedScores(int[] arr)
        {
            Console.WriteLine("\nSorted Exam Scores:");
            foreach (int score in arr)
            {
                Console.Write(score + " ");
            }
            Console.WriteLine();
        }
    }
}
