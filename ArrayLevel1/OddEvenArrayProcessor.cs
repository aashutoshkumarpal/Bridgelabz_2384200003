using System;

namespace ArrayLevel1
{
    class OddEvenArrayProcessor
    {
        public void OddEvenArrays()
        {
            // Get input from the user
            Console.Write("Enter a natural number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the input is a valid natural number
            if (number <= 0)
            {
                Console.WriteLine("Error: Enter a number greater than zero.");
                return;
            }

            // Arrays to store odd and even numbers
            int[] oddNumbers = new int[number / 2 + 1];
            int[] evenNumbers = new int[number / 2 + 1];
            int oddIndex = 0, evenIndex = 0;

            // Separate numbers into odd and even arrays
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                    evenNumbers[evenIndex++] = i;
                else
                    oddNumbers[oddIndex++] = i;
            }

            // Print odd numbers
            Console.WriteLine("\nOdd Numbers:");
            for (int i = 0; i < oddIndex; i++)
                Console.Write(oddNumbers[i] + " ");

            // Print even numbers
            Console.WriteLine("\n\nEven Numbers:");
            for (int i = 0; i < evenIndex; i++)
                Console.Write(evenNumbers[i] + " ");

            Console.WriteLine();
        }
    }
}
