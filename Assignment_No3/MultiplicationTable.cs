using System;

namespace Assignment_No3
{
    class MultiplicationTable
    {
        public void GenerateTable()
        {
            // Take integer input from the user
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Print the multiplication table from 6 to 9
            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
    }
}
