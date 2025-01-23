using System;

namespace Assignment_No3
{
    class FactorialCalculator2
    {
        public void Factorial()
        {
            // Take user input for the number
            Console.Write("Enter a positive integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the user entered a positive integer
            if (number < 0)
            {
                Console.WriteLine("The number is not a positive integer.");
                return;
            }

            // Initialize factorial variable to 1
            int factorial = 1;

            // Compute factorial using for loop
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            // Print the factorial result
            Console.WriteLine($"The factorial of {number} is: {factorial}");
        }
    }
}
