using System;

namespace MethodLevel1
{
    class QuotientAndRemainder
    {
        public void InputMethod()
        {
            // Get user input for two numbers
            Console.Write("Enter the dividend (number): ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            // Call the method to find the quotient and remainder
            int[] result = FindRemainderAndQuotient(number, divisor);

            // Display the result
            Console.WriteLine($"The quotient is: {result[0]}");
            Console.WriteLine($"The remainder is: {result[1]}");
        }

        // Method to find the quotient and remainder of the division
        public static int[] FindRemainderAndQuotient(int number, int divisor)
        {
            int quotient = number / divisor;
            int remainder = number % divisor;

            return new int[] { quotient, remainder };
        }
    }
}
