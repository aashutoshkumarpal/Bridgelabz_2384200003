using System;

namespace MethodLevel1
{
    class SimpleInterestCalculator
    {
        public void InputMethod()
        {
            // Take user input for Principal, Rate, and Time
            Console.Write("Enter Principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Rate of Interest (in %): ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Time (in years): ");
            double time = Convert.ToDouble(Console.ReadLine());

            // Calculate simple interest
            double simpleInterest = CalculateSimpleInterest(principal, rate, time);

            // Display the result
            Console.WriteLine($"The Simple Interest is {simpleInterest:F2} for Principal {principal}, Rate of Interest {rate}%, and Time {time} years.");
        }

        // Method to calculate simple interest
        public static double CalculateSimpleInterest(double principal, double rate, double time)
        {
            return (principal * rate * time) / 100;
        }
    }
}
