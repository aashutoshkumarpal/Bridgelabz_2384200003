using System;

namespace Assignment_No2
{
    
    class DoubleOpt
    {
        public void PerformOperations()
        {
            // Take three double numbers as input from the user
            Console.Write("Enter the first number (a): ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number (b): ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third number (c): ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Perform the specified operations
            double result1 = a + b * c;       
            double result2 = a * b + c;       
            double result3 = c + a / b;       
            double result4 = a % b + c;       

            // Display the results
            Console.WriteLine($"The results of Double Operations are: ");
            Console.WriteLine($"a + b * c = {result1:F2}");
            Console.WriteLine($"a * b + c = {result2:F2}");
            Console.WriteLine($"c + a / b = {result3:F2}");
            Console.WriteLine($"a % b + c = {result4:F2}");
        }
    }
}
