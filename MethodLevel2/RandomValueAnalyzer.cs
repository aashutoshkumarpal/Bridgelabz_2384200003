using System;

namespace MethodLevel2
{
    public class RandomValueAnalyzer
    {
        // Method to generate an array of 4-digit random numbers
        public static int[] Generate4DigitRandomArray(int size)
        {
            Random random = new Random();
            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(1000, 10000); // Generate a random 4-digit number
            }

            return numbers;
        }

        // Method to find the average, min, and max values of an array
        public static double[] FindAverageMinMax(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];
            int sum = 0;

            foreach (int number in numbers)
            {
                min = Math.Min(min, number);
                max = Math.Max(max, number);
                sum += number;
            }

            double average = (double)sum / numbers.Length;
            return new double[] { average, min, max };
        }

        // Input and output handling
        public static void InputAndAnalyze()
        {
            const int size = 5; // Size of the array
            int[] randomNumbers = Generate4DigitRandomArray(size);

            Console.WriteLine("Generated 4-digit random numbers:");
            foreach (int number in randomNumbers)
            {
                Console.WriteLine(number);
            }

            double[] results = FindAverageMinMax(randomNumbers);

            Console.WriteLine($"\nResults:");
            Console.WriteLine($"Average: {results[0]:F2}");
            Console.WriteLine($"Minimum: {results[1]}");
            Console.WriteLine($"Maximum: {results[2]}");
        }
    }
}
