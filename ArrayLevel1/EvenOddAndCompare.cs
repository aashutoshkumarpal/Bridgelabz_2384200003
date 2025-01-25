using System;

namespace ArrayLevel1
{
    class EvenOddAndCompare
    {
        public void ProcessArray()
        {
            int[] numbers = new int[5];

            Console.WriteLine("Enter 5 integers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nResults:");
            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    Console.WriteLine(number + " is positive and " + (number % 2 == 0 ? "even." : "odd."));
                }
                else if (number < 0)
                {
                    Console.WriteLine(number + " is negative.");
                }
                else
                {
                    Console.WriteLine("The number is zero.");
                }
            }

            // Compare the first and last elements
            Console.WriteLine("\nComparison of first and last elements:");
            if (numbers[0] == numbers[^1])
            {
                Console.WriteLine("The first and last elements are equal.");
            }
            else if (numbers[0] > numbers[^1])
            {
                Console.WriteLine("The first element is greater than the last element.");
            }
            else
            {
                Console.WriteLine("The first element is less than the last element.");
            }
        }
    }
}
