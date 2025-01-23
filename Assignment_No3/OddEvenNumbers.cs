using System;

namespace Assignment_No3
{
    class OddEvenNumbers
    {
        public void PrintOddEven()
        {
            // Take user input for the number
            Console.Write("Enter a positive integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the user entered a positive integer (natural number)
            if (number <= 0)
            {
                Console.WriteLine("The number is not a natural number.");
                return;
            }

            // Iterate from 1 to the entered number
            for (int i = 1; i <= number; i++)
            {
                // Check if the number is even or odd
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is an even number.");
                }
                else
                {
                    Console.WriteLine($"{i} is an odd number.");
                }
            }
        }
    }
}
