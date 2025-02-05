using System;

namespace Assignment_No2
{
    class SimpleInterestCalculator
    {
        public void CalculateSimpleInterest()
        {
            // Get input values for principal, rate, and time
            Console.Write("Enter the Principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the Rate of Interest: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the Time period (in years): ");
            double time = Convert.ToDouble(Console.ReadLine());
            
            // Calculate Simple Interest
            double simpleInterest = (principal * rate * time) / 100;
            
            // Display the result
            Console.WriteLine($@"
The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate} and Time {time}.
");
        }
    }
}
