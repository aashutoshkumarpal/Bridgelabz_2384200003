using System;

namespace ArrayLevel1
{
    class MultiplicationTable
    {
        public void PrintTable()
        {
            Console.Write("Enter a number to generate its multiplication table: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int[] table = new int[10];
			
			// loop for Storing the table of entered number 
            for (int i = 0; i < 10; i++)
            {
                table[i] = number * (i + 1);
            }
			// Display the table in specified format
			
            Console.WriteLine($"\nMultiplication Table for {number}:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{number} * {i + 1} = {table[i]}");
            }
        }
    }
}
