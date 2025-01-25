using System;

namespace ArrayLevel2
{
    class DigitFrequency
    {
        
        public void FindDigitFrequency()
        {
            
            Console.Write("Enter a number: ");
            string number = Console.ReadLine();

            // Create an array to store the frequency of each digit (0-9)
            int[] frequency = new int[10];

            // Loop through the number, extract each digit and update its frequency
            foreach (char digitChar in number)
            {
                if (Char.IsDigit(digitChar))  
                {
                    int digit = Convert.ToInt32(digitChar.ToString());
                    frequency[digit]++; /
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }
            }

            // Display the frequency of each digit
            Console.WriteLine("\nFrequency of each digit in the number:");

            for (int i = 0; i < frequency.Length; i++)
            {
                if (frequency[i] > 0)
                {
                    Console.WriteLine($"Digit {i}: {frequency[i]} times");
                }
            }
        }
    }
}
