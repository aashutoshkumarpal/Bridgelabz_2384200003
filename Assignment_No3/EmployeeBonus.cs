using System;

namespace Assignment_No3
{
    class EmployeeBonus
    {
        public void CalculateBonus()
        {
            // Take salary and years of service input from the user
            Console.Write("Enter the employee's salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the employee's years of service: ");
            int yearsOfService = Convert.ToInt32(Console.ReadLine());

            // Check if the employee qualifies for the bonus
            double bonus = 0;
            if (yearsOfService > 5)
            {
                bonus = salary * 0.05; // 5% bonus if years of service is more than 5
            }

            // Print the bonus amount
            Console.WriteLine($"The bonus amount is: {bonus:C}");
        }
    }
}
