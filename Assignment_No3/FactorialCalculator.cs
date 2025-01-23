using System;

namespace Assignment_No3
{
    class FactorialCalculator
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
            int i = 1;

            // Compute factorial using while loop
            while (i <= number)
            {
                factorial *= i;
                i++;
            }

            // Print the factorial result
            Console.WriteLine($"The factorial of {number} is: {factorial}");
        }
    }
}
