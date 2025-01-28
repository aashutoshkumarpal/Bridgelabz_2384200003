using System;

namespace MethodLevel2
{
    class NaturalNumberSum
    {
        public void InputMethod()
        {
            // Get user input for n
            Console.Write("Enter a natural number (positive integer): ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Check if the input is a natural number
            if (n <= 0)
            {
                Console.WriteLine("The entered number is not a natural number. Exiting...");
                return;
            }

            // Calculate the sum using recursion
            int sumUsingRecursion = FindSumUsingRecursion(n);

            // Calculate the sum using the formula
            int sumUsingFormula = FindSumUsingFormula(n);

            // Compare and display the results
            Console.WriteLine($"Sum of first {n} natural numbers (using recursion): {sumUsingRecursion}");
            Console.WriteLine($"Sum of first {n} natural numbers (using formula): {sumUsingFormula}");

            if (sumUsingRecursion == sumUsingFormula)
            {
                Console.WriteLine("The results match! Both methods give the correct sum.");
            }
            else
            {
                Console.WriteLine("The results do not match. There might be an error in the calculations.");
            }
        }

        // Method to find the sum of n natural numbers using recursion
        public int FindSumUsingRecursion(int n)
        {
            if (n == 1)
                return 1; // Base case
            return n + FindSumUsingRecursion(n - 1); // Recursive step
        }

        // Method to find the sum of n natural numbers using the formula
        public int FindSumUsingFormula(int n)
        {
            return n * (n + 1) / 2;
        }
    }
}
