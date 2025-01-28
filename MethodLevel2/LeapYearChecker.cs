using System;

namespace MethodLevel2
{
    class LeapYearChecker
    {
        public void InputMethod()
        {
            // Get user input for the year
            Console.Write("Enter a year (greater than or equal to 1582): ");
            int year = Convert.ToInt32(Console.ReadLine());

            // Check if the year is valid
            if (year < 1582)
            {
                Console.WriteLine("The program only works for years >= 1582. Exiting...");
                return;
            }

            // Check if the year is a leap year
            bool isLeapYear = CheckLeapYear(year);

            // Display the result
            if (isLeapYear)
            {
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year.");
            }
        }

        // Method to check if a year is a leap year
        public bool CheckLeapYear(int year)
        {
            // A leap year is divisible by 4 and not divisible by 100, or divisible by 400
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
