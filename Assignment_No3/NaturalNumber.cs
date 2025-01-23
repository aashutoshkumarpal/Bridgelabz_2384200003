using System;

namespace Assignment_No3
{
    class NaturalNumber
    {
        public void CheckAndSumNaturalNumbers()
        {
            // Input the number
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is a natural number
            if (number >= 0)
            {
                // Calculate the sum of n natural numbers
                int sum = number * (number + 1) / 2;

                // Output the result
                Console.WriteLine($"The sum of {number} natural numbers is {sum}");
            }
            else
            {
                // Output if the number is not a natural number
                Console.WriteLine($"The number {number} is not a natural number.");
            }
        }
    }
}
