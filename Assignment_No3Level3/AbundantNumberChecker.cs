using System;

namespace AssignmentNo3Level3
{
    class AbundantNumberChecker
    {
        public void CheckAbundantNumber()
        {
            // Get input from the user
            Console.Write("Enter a number to check if it is an Abundant Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Validate the input
            if (number <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                return;
            }

            // Initialize sum of divisors
            int sum = 0;

            // Find divisors and calculate the sum
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0) // Check if i is a divisor of number
                {
                    sum += i;
                }
            }

            // Check if the number is Abundant
            if (sum > number)
            {
                Console.WriteLine($"{number} is an Abundant Number.");
            }
            else
            {
                Console.WriteLine($"{number} is Not an Abundant Number.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AbundantNumberChecker checker = new AbundantNumberChecker();
            checker.CheckAbundantNumber();
        }
    }
}
