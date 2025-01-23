using System;

namespace AssignmentNo3Level3
{
    class ArmstrongChecker
    {
        public void CheckArmstrongNumber()
        {
            // Get user input
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Initialize variables
            int originalNumber = number;
            int sum = 0;

            // Process each digit
            while (originalNumber != 0)
            {
                // Find the remainder (last digit)
                int digit = originalNumber % 10;

                // Add the cube of the digit to the sum
                sum += digit * digit * digit;

                // Remove the last digit from the original number
                originalNumber /= 10;
            }

            // Check if the sum is equal to the original number
            if (sum == number)
            {
                Console.WriteLine($"The number {number} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"The number {number} is not an Armstrong number.");
            }
        }
    }
}
