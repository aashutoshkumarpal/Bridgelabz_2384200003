using System;

namespace Assignment_No3Level2
{
    class LeapYearChecker2
    {
        public void CheckLeapYear()
        {
            // Take the year input from the user
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            // Check if the year is greater than or equal to 1582 (Gregorian calendar)
            if (year < 1582)
            {
                Console.WriteLine("Year must be greater than or equal to 1582.");
                return;
            }

            // Part 1: Using a single if statement with logical && and || operators
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year.");
            }
        }
    }
}
