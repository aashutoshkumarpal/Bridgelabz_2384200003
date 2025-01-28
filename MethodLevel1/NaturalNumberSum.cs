using System;

namespace MethodLevel1
{
    class NaturalNumberSum
    {
        public void InputMethod()
        {
            // Get user input for the value of n
            Console.Write("Enter a positive integer n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Call the method to calculate the sum of the first n natural numbers
            int sum = CalculateSum(n);

            // Display the result
            Console.WriteLine($"The sum of the first {n} natural numbers is: {sum}");
        }

        // Method to calculate the sum of first n natural numbers using a loop
        public static int CalculateSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
