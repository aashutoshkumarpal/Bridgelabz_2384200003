using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    internal class BubbleSort
    {
        // Method to take user input for student marks
        public void InputMethod()
        {
            Console.Write("Enter the number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] studentMarks = new int[n];

            Console.WriteLine("Enter student marks:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Mark {i + 1}: ");
                studentMarks[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Sort the marks using Bubble Sort
            Sort(studentMarks);

            // Display the sorted marks
            DisplaySortedMarks(studentMarks);
        }

        // Method to sort student marks using Bubble Sort
        public void Sort(int[] studentMarks)
        {
            for (int i = 0; i < studentMarks.Length; i++)
            {
                bool swapped = false;

                for (int j = 0; j < studentMarks.Length - i - 1; j++)
                {
                    if (studentMarks[j] > studentMarks[j + 1])
                    {
                        int temp = studentMarks[j];
                        studentMarks[j] = studentMarks[j + 1];
                        studentMarks[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
        }

        // Method to display sorted student marks
        private void DisplaySortedMarks(int[] studentMarks)
        {
            Console.WriteLine("\nSorted Student Marks:");
            foreach (int mark in studentMarks)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();
        }
    }
}
