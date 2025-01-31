using System;

namespace DateTimeAssignment
{
    class DateArithmetic
    {
        public void PerformDateArithmetic()
        {
            Console.Write("Enter a date (yyyy-MM-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime inputDate))
            {
                DateTime modifiedDate = inputDate.AddDays(7).AddMonths(1).AddYears(2); // Adding 7 days , adding 1 month and 2 years
                Console.WriteLine($"Date after adding 7 days, 1 month, and 2 years: {modifiedDate:yyyy-MM-dd}");

                modifiedDate = modifiedDate.AddDays(-21); // Subtracting 3 weeks
                Console.WriteLine($"Date after subtracting 3 weeks: {modifiedDate:yyyy-MM-dd}");
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter a valid date.");
            }
        }
    }
}
