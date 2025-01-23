using System;

namespace AssignmentNo3Level3
{
    class DigitCounter
    {
        public void CountDigits()
        {
            // Get user input
            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Handle negative numbers by taking absolute value
            number = Math.Abs(number);

            // Initialize the count variable
            int count = 0;

            // Check for the special case where the number is 0
            if (number == 0)
            {
                count = 1;
            }
            else
            {
                // Loop to count the digits
                while (number != 0)
                {
                    // Remove the last digit
                    number /= 10;

                    // Increment the count
                    count++;
                }
            }

            // Display the result
            Console.WriteLine($"The number of digits is: {count}");
        }
    }
}
