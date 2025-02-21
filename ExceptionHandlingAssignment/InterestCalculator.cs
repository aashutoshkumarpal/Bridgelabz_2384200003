using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecptionHandlingAssignment
{
    internal class InterestCalculator
    {
        public double CalculateInterest(double amount, double rate, int years)
        {
            if (amount < 0 || rate < 0)
            {
                throw new ArgumentException("Amount and rate must be positive.");
            }

            return (amount * rate * years) / 100; // Simple interest formula
        }

        public void InputMethod()
        {
            try
            {
                Console.Write("Enter principal amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter interest rate (% per year): ");
                double rate = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number of years: ");
                int years = Convert.ToInt32(Console.ReadLine());

                double interest = CalculateInterest(amount, rate, years);

                Console.WriteLine($"Calculated Interest: {interest}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Invalid input: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input! Please enter numeric values.");
            }
        }
    }
}
