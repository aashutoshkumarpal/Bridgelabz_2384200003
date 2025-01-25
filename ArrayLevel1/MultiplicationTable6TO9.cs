using System;

namespace ArrayLevel1
{
    class MultiplicationTable6TO9
    {
        public void GenerateTable()
        {
            // Prompt the user to enter a number
            Console.Write("Enter a number to generate its multiplication table from 6 to 9: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Define an array to store the multiplication results
            int[] multiplicationResult = new int[4];

            // Calculate the multiplication table for numbers 6 to 9
            for (int i = 6; i <= 9; i++)
            {
                multiplicationResult[i - 6] = number * i;
            }

            // Display the results
            Console.WriteLine($"\nMultiplication Table for {number} from 6 to 9:");
            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine($"{number} * {i} = {multiplicationResult[i - 6]}");
            }
        }
    }
}
