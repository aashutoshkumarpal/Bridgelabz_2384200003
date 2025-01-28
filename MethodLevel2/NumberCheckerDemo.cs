using System;

namespace MethodLevel2
{
    public class NumberChecker
    {
        // Method to check if a number is positive or negative
        public static bool IsPositive(int number)
        {
            return number >= 0;
        }

        // Method to check if a number is even or odd
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // Method to compare two numbers
        public static int Compare(int number1, int number2)
        {
            if (number1 > number2) return 1;
            if (number1 < number2) return -1;
            return 0;
        }
    }

    class NumberCheckerDemo
    {
        public void InputMethod()
        {
            int[] numbers = new int[5];

            Console.WriteLine("Enter 5 numbers:");

            // Take user input for 5 numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nNumber Analysis Results:");
            // Analyze each number
            for (int i = 0; i < numbers.Length; i++)
            {
                if (NumberChecker.IsPositive(numbers[i]))
                {
                    if (NumberChecker.IsEven(numbers[i]))
                    {
                        Console.WriteLine($"Number {numbers[i]} is positive and even.");
                    }
                    else
                    {
                        Console.WriteLine($"Number {numbers[i]} is positive and odd.");
                    }
                }
                else
                {
                    Console.WriteLine($"Number {numbers[i]} is negative.");
                }
            }

            // Compare the first and last elements
            Console.WriteLine("\nComparison of the first and last numbers:");
            int comparisonResult = NumberChecker.Compare(numbers[0], numbers[^1]);

            if (comparisonResult == 1)
            {
                Console.WriteLine($"The first number ({numbers[0]}) is greater than the last number ({numbers[^1]}).");
            }
            else if (comparisonResult == -1)
            {
                Console.WriteLine($"The first number ({numbers[0]}) is less than the last number ({numbers[^1]}).");
            }
            else
            {
                Console.WriteLine($"The first number ({numbers[0]}) is equal to the last number ({numbers[^1]}).");
            }
        }
    }

}
