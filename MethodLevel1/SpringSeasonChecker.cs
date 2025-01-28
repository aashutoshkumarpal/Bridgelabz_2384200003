using System;

namespace MethodLevel1
{
    class SpringSeasonChecker
    {
        public void InputMethod()
        {
            // Take user input for month and day
            Console.Write("Enter the month (as an integer, e.g., 3 for March): ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the day of the month: ");
            int day = Convert.ToInt32(Console.ReadLine());

            // Check if it's Spring season
            bool isSpring = IsSpringSeason(month, day);

            // Display the result
            if (isSpring)
            {
                Console.WriteLine("It's a Spring Season.");
            }
            else
            {
                Console.WriteLine("Not a Spring Season.");
            }
        }

        // Method to check if the date falls in the Spring season
        public static bool IsSpringSeason(int month, int day)
        {
            if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
            {
                return true;
            }
            return false;
        }
    }
}
