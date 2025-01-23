using System;

namespace AssignmentNo3Level3
{
    class HarshadNumberChecker
    {
        public void CheckHarshadNumber()
        {
            // Get user input
            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Handle negative numbers by taking absolute value
            int originalNumber = Math.Abs(number);

            // Initialize sum variable
            int sum = 0;

            // Calculate the sum of digits
            int tempNumber = originalNumber;
            while (tempNumber > 0)
            {
                int digit = tempNumber % 10; // Get the last digit
                sum += digit;               // Add it to the sum
                tempNumber /= 10;           // Remove the last digit
            }

            // Check if the original number is divisible by the sum of its digits
            if (originalNumber % sum == 0)
            {
                Console.WriteLine($"The number {number} is a Harshad Number.");
            }
            else
            {
                Console.WriteLine($"The number {number} is NOT a Harshad Number.");
            }
        }
    }
}
