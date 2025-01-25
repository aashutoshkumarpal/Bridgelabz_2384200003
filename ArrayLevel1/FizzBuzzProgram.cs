using System;

namespace ArrayLevel1
{
    class FizzBuzzProgram
    {
        
        public void FizzBuzz()
        {
            // Take user input for a positive integer
            Console.Write("Enter a positive integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is positive
            if (number <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                return;
            }

            // Create a string array to save the results
            string[] results = new string[number + 1];  // Array size is number + 1 because we include 0

            // Loop from 0 to the number
            for (int i = 0; i <= number; i++)
            {
                // Check for multiples of both 3 and 5 (FizzBuzz)
                if (i % 3 == 0 && i % 5 == 0)
                {
                    results[i] = "FizzBuzz";
                }
                // Check for multiples of 3 (Fizz)
                else if (i % 3 == 0)
                {
                    results[i] = "Fizz";
                }
                // Check for multiples of 5 (Buzz)
                else if (i % 5 == 0)
                {
                    results[i] = "Buzz";
                }
                // Otherwise, just store the number
                else
                {
                    results[i] = i.ToString();
                }
            }

            // Display the results in the format: Position 1 = 1, Position 2 = Fizz, ...
            Console.WriteLine("FizzBuzz Results:");
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine($"Position {i} = {results[i]}");
            }
        }
    }
}
