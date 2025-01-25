using System;

namespace ArrayLevel1
{
    class NumberArrayProcessor
    {
        public void ProcessNumbers()
        {
            // Array to store up to 10 numbers
            double[] numbers = new double[10];
     
            double total = 0.0;
            
            int index = 0;

            Console.WriteLine("Enter up to 10 numbers. Enter 0 or a negative number to stop:");

            // Infinite loop to get user input
            while (true)
            {
                Console.Write($"Enter number {index + 1}: ");
                double input = Convert.ToDouble(Console.ReadLine());

                // Break the loop if the user enters 0, a negative number, or the array is full
                if (input <= 0 || index == 10)
                {
                    break;
                }

                // Store the valid input in the array and increment the index
                numbers[index] = input;
                index++;
            }

            Console.WriteLine("\nYou entered the following numbers:");
            // Loop through the array to display entered numbers and calculate the total sum
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(numbers[i]);
                total += numbers[i];
            }

            // Display the total sum of the numbers
            Console.WriteLine($"\nThe total sum of the numbers is: {total}");
        }
    }
}
