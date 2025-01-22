using System;

namespace Assignment_No2
{
    class NumberSwapper
    {
        public void SwapNumbers()
        {
            // Prompt the user to enter the first number
            Console.Write("Enter the first number: ");
            
            // Read and convert the first number to an integer
            int number1 = Convert.ToInt32(Console.ReadLine());
            
            // Prompt the user to enter the second number
            Console.Write("Enter the second number: ");
            
            // Read and convert the second number to an integer
            int number2 = Convert.ToInt32(Console.ReadLine());
            
            // Display the numbers before swapping
            Console.WriteLine($"\nBefore Swapping: Number1 = {number1}, Number2 = {number2}");
            
            // Swap the values of number1 and number2 using a temporary variable
            int temp = number1;
            number1 = number2;
            number2 = temp;
            
            // Display the numbers after swapping
            Console.WriteLine($"After Swapping: Number1 = {number1}, Number2 = {number2}");
        }
    }
}
