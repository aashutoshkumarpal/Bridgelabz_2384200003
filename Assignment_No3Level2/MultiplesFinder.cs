using System;

namespace Assignment_No3Level2
{
    class MultiplesFinder
    {
        public void FindMultiplesBelow100()
        {
            
            Console.Write("Enter a positive integer to find its multiples below 100: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Ensure the input is valid
            if (number <= 0)
            {
                Console.WriteLine("Please enter a positive integer greater than 0.");
                return;
            }

            // Display multiples of the number below 100
            Console.WriteLine($"Multiples of {number} below 100 are:");

            // Loop backward from 100 to 1
            for (int i = 100; i >= 1; i--)
            {
                // Check if the number divides i perfectly
                if (i % number == 0)
                {
                    Console.WriteLine(i); // Print the multiple
                }
            }
        }
    }
}
