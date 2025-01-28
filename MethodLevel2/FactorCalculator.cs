using System;

namespace MethodLevel2
{
    class FactorCalculator
    {
        public void InputMethod()
        {
            // Get user input for the number
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Call the method to find the factors and store them in an array
            int[] factors = FindFactors(number);

            // Display the factors
            Console.WriteLine($"Factors of {number} are: ");
            foreach (int factor in factors)
            {
                if (factor != 0) // to avoid zero in the output
                    Console.Write(factor + " ");
            }
            Console.WriteLine();

            // Calculate and display the sum of the factors
            int sum = CalculateSum(factors);
            Console.WriteLine($"Sum of factors: {sum}");

            // Calculate and display the sum of the squares of the factors
            double sumOfSquares = CalculateSumOfSquares(factors);
            Console.WriteLine($"Sum of squares of factors: {sumOfSquares}");

            // Calculate and display the product of the factors
            long product = CalculateProduct(factors);
            Console.WriteLine($"Product of factors: {product}");
        }

        // Method to find factors of the number and return them in an array
        public static int[] FindFactors(int number)
        {
            // First loop to count the factors
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    count++;
            }

            // Initialize the array to store factors
            int[] factors = new int[count];
            int index = 0;

            // Second loop to store the factors into the array
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors[index] = i;
                    index++;
                }
            }

            return factors;
        }

        // Method to calculate the sum of factors using the factors array
        public static int CalculateSum(int[] factors)
        {
            int sum = 0;
            foreach (int factor in factors)
            {
                if (factor != 0) // to avoid adding zero
                    sum += factor;
            }
            return sum;
        }

        // Method to calculate the sum of squares of the factors using the factors array
        public static double CalculateSumOfSquares(int[] factors)
        {
            double sumOfSquares = 0;
            foreach (int factor in factors)
            {
                if (factor != 0) // to avoid squaring zero
                    sumOfSquares += Math.Pow(factor, 2);
            }
            return sumOfSquares;
        }

        // Method to calculate the product of the factors using the factors array
        public static long CalculateProduct(int[] factors)
        {
            long product = 1;
            foreach (int factor in factors)
            {
                if (factor != 0) // to avoid multiplying by zero
                    product *= factor;
            }
            return product;
        }
    }
}
