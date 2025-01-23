using System;

namespace Assignment_No3
{
    class SumOfNumbers
    {
        public void CalculateSum()
        {
            double total = 0.0; 
            double userInput;

            // Start the loop to get numbers from the user
            do
            {
                
                Console.Write("Enter a number (enter 0 to stop): ");
                userInput = Convert.ToDouble(Console.ReadLine());

                // If the entered number is not 0, add it to the total
                if (userInput != 0)
                {
                    total += userInput;
                }

            } while (userInput != 0); // Continue the loop until user enters 0

            // Print the total sum
            Console.WriteLine($"The total sum is: {total}");
        }
    }
}
