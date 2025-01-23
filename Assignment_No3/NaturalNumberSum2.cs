using System;

namespace Assignment_No3
{
    class NaturalNumberSum2
    {
        public void FindSumAndCompare()
        {
            // Take user input for the number
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Check if the number is a natural number 
            if (n <= 0)
            {
                Console.WriteLine("The number is not a natural number.");
                return;
            }

            // solve sum using for loop
            int sumUsingLoop = 0;
            for (int i = 1; i <= n; i++)
            {
                sumUsingLoop += i;
            }

            // solve sum using the formula
            int sumUsingFormula = n * (n + 1) / 2;

            // Print both results
            Console.WriteLine($"Sum using for loop: {sumUsingLoop}");
            Console.WriteLine($"Sum using formula: {sumUsingFormula}");

            // Compare the results
            if (sumUsingLoop == sumUsingFormula)
            {
                Console.WriteLine("Both methods give the same result.");
            }
            else
            {
                Console.WriteLine("The results do not match.");
            }
        }
    }
}
