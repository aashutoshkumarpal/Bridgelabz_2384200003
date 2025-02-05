using System;

namespace Assignment_No2
{
    class IncomeCalculator
    {
        public void CalculateTotalIncome()
        {
            // Ask the user for their salary
            Console.Write("Enter your salary (INR): ");
            
            // Read the input and convert it to a double
            double salary = Convert.ToDouble(Console.ReadLine());
            
            // Ask the user for their bonus
            Console.Write("Enter your bonus (INR): ");
            
            // Read the input and convert it to a double
            double bonus = Convert.ToDouble(Console.ReadLine());
            
            // Calculate the total income by adding salary and bonus
            double totalIncome = salary + bonus;
            
            // Display the result in a friendly and clear way
            Console.WriteLine($" The salary is INR {salary:F2} and bonus is INR {bonus:F2}. Hence, Total Income is INR {totalIncome:F2}. ");
        }
    }
}
