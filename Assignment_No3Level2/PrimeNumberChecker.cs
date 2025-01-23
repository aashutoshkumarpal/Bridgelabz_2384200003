using System;

namespace Assignment_No3Level2
{
    class PrimeNumberChecker
    {
        public void CheckPrimeNumber()
        {
            
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;

            // Check if the number is less than or equal to 1 (not a prime number)
            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                // Loop through all numbers from 2 to the number - 1 to check divisibility
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break; 
                    }
                }
            }

            // Output the result
            if (isPrime)
            {
                Console.WriteLine($"{number} is a Prime Number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a Prime Number.");
            }
        }
    }
}
