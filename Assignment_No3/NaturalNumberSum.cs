using System;

namespace Assignment_No3
{
    class NaturalNumberSum
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

            // solve sum using while loop
            int sumUsingLoop = 0;
            int i = 1;
            while (i <= n)
            {
                sumUsingLoop += i;
                i++;
            }

            // solve sum using the formula 
            int sumUsingFormula = n * (n + 1) / 2;

            // Print both results
            Console.WriteLine($"Sum using while loop: {sumUsingLoop}");
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
