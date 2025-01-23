using System;

namespace Assignment_No3Level2
{
    class FizzBuzzProgram
    {
        public void PlayFizzBuzz()
        {
            
            Console.Write("Enter a positive integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            
            if (number <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                return;
            }

            // Loop from 1 to the entered number
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                // Print the number if none of the above
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
