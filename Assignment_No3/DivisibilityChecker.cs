using System;

namespace Assignment_No3
{
    class DivisibilityChecker
    {
        public void CheckDivisibilityBy5()
        {
            // Prompt the user for input
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            // Check divisibility
            if (number % 5 == 0)
            {
                Console.WriteLine($"Is the number {number} divisible by 5? Yes");
            }
            else
            {
                Console.WriteLine($"Is the number {number} divisible by 5? No");
            }
        }
    }
}
