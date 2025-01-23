using System;

namespace Assignment_No3Level2
{
    class GreatestFactorFinder
    {
        public void FindGreatestFactor()
        {
            // Get user input
            Console.Write("Enter a positive integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Ensure the input is a positive integer
            if (number <= 0)
            {
                Console.WriteLine("Please enter a positive integer greater than 0.");
                return;
            }

            // Initialize the greatest factor variable
            int greatestFactor = 1;

            // Loop from the number - 1 down to 1
            for (int i = number - 1; i >= 1; i--)
            {
                // Check if the number is divisible by i
                if (number % i == 0)
                {
                    greatestFactor = i;
                    break; // Exit the loop as we found the greatest factor
                }
            }

            // Display the greatest factor
            Console.WriteLine($"The greatest factor of {number} (besides itself) is: {greatestFactor}");
        }
    }
}
