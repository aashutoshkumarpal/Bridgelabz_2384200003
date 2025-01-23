using System;

namespace Assignment_No3
{
    class SumOfNumbers2
    {
        public void CalculateSum()
        {
            double total = 0.0; 

            // Infinite while loop
            while (true)
            {
                
                Console.Write("Enter a number (enter 0 or a negative number to stop): ");
                double userInput = Convert.ToDouble(Console.ReadLine());

                // Check if the entered number is 0 or negative
                if (userInput <= 0)
                {
                    break; // Exit the loop if 0 or a negative number is entered
                }

                // If the number is positive, add it to the total
                total += userInput;
            }

            // Print the total sum
            Console.WriteLine($"The total sum is: {total}");
        }
    }
}
