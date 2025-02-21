using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecptionHandlingAssignment
{
    internal class ArrayHandler
    {
        // Method to retrieve value from the array
        public void GetArrayValue(int[] arr, int index)
        {
            try
            {
                if (arr == null)
                {
                    throw new NullReferenceException("Array is not initialized!");
                }

                Console.WriteLine($"Value at index {index}: {arr[index]}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: Invalid index!");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error: Array is not initialized!");
            }
        }
    
        public void InputMethod()
        {
            try
            {
                Console.Write("Enter the size of the array: ");
                int size = Convert.ToInt32(Console.ReadLine());

                int[] arr = new int[size];

                // Accepting array elements
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter element {i}: ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("Enter index to retrieve value: ");
                int index = Convert.ToInt32(Console.ReadLine());

                
                GetArrayValue(arr, index);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input! Please enter a number.");
            }
        }
    }
}
