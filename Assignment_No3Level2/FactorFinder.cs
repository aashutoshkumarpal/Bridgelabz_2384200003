using System;

namespace Assignment_No3Level2
{
    class FactorFinder
    {
        public void FindFactors()
        {
            
            Console.Write("Enter a positive integer to find its factors: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Ensure the input is valid
            if (number <= 0)
            {
                Console.WriteLine("Please enter a positive integer greater than 0.");
                return;
            }

            // Display factors
            Console.WriteLine($"Factors of {number} are:");

            // Loop to find factors
            for (int i = 1; i <= number; i++) // Include the number itself as a factor
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i); // Print the factor
                }
            }
        }
    }
}
