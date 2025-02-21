using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecptionHandlingAssignment
{
    internal class NestedTryCatch
    {
        public void InputMethod()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            try
            {
                Console.Write("Enter the index of the element: ");
                int index = Convert.ToInt32(Console.ReadLine());

                try
                {
                    int element = numbers[index]; // May throw IndexOutOfRangeException
                    Console.Write("Enter the divisor: ");
                    int divisor = Convert.ToInt32(Console.ReadLine());

                    try
                    {
                        int result = element / divisor; // May throw DivideByZeroException
                        Console.WriteLine($"Result: {result}");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Cannot divide by zero!");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid array index!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input! Please enter numeric values.");
            }
        }
    }
}
