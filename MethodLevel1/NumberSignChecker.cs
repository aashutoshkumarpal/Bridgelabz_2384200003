using System;

namespace MethodLevel1
{
    class NumberSignChecker
    {
        public void InputMethod()
        {
            // Take user input for a number
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check the sign of the number
            int result = CheckNumberSign(number);

            // Display the result
            if (result == 1)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (result == -1)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }

        // Method to check whether a number is positive, negative, or zero
        public static int CheckNumberSign(int number)
        {
            if (number > 0)
            {
                return 1; // Positive number
            }
            else if (number < 0)
            {
                return -1; // Negative number
            }
            else
            {
                return 0; // Zero
            }
        }
    }
}
