using System;

namespace ArrayLevel2
{
    class ReverseNumber
    {
        
        static void ReverseDigits()
        {
            // Take user input for the number
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Find the number of digits in the number
            int count = (int)Math.Floor(Math.Log10(number) + 1);

            // Define an array to store the digits
            int[] digits = new int[count];

            // Loop to extract digits from the number and store them in the array
            for (int i = 0; i < count; i++)
            {
                digits[i] = number % 10;  
                number = number / 10;  
            }

            // Define an array to store the digits in reverse order
            int[] reversedDigits = new int[count];

            // Loop to copy the digits into reversed array
            for (int i = 0; i < count; i++)
            {
                reversedDigits[i] = digits[count - 1 - i];  // Reverse the digits
            }

            // Display the reversed number
            Console.Write("The reversed number is: ");
            foreach (int digit in reversedDigits)
            {
                Console.Write(digit);
            }
        }
    }
}
