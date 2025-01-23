using System;

namespace Assignment_No3Level2
{
    class PowerCalculator
    {
        public void CalculatePower()
        {
            // Get integer input for number and power
            Console.Write("Enter the base number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the power: ");
            int power = Convert.ToInt32(Console.ReadLine());

            // Initialize result variable
            int result = 1;

            // Calculate the power using a for loop
            for (int i = 1; i <= power; i++)
            {
                result *= number; // Multiply result with the number
            }

            // Display the result
            Console.WriteLine($"{number} raised to the power {power} is: {result}");
        }
    }
}
