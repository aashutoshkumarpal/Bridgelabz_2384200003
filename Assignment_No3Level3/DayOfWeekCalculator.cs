 using System;

namespace AssignmentNo3Level3
{
    class DayOfWeekCalculator
    {
        public void CalculateDayOfWeek(int month, int day, int year)
        {
            // Calculate y0
            int y0 = year - (14 - month) / 12;

            // Calculate x
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;

            // Calculate m0
            int m0 = month + 12 * ((14 - month) / 12) - 2;

            // Calculate day of the week
            int d0 = (day + x + (31 * m0) / 12) % 7;

            // Output the result
            Console.WriteLine($"The day of the week for the date {month}/{day}/{year} is: {d0}");
            Console.WriteLine($"0 = Sunday, 1 = Monday, 2 = Tuesday, 3 = Wednesday, 4 = Thursday, 5 = Friday, 6 = Saturday");
        }
    }
}
