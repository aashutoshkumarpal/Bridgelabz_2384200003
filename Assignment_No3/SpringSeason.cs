using System;

namespace Assignment_No3
{
    class SpringSeason
    {
        static void Main(string[] args)
        {
            // Check if two arguments are provided
            if (args.Length != 2)
            {
                Console.WriteLine("Please provide both month and day as command-line arguments.");
                Console.WriteLine("Usage: SpringSeason <month> <day>");
                return;
            }

            // take command-line arguments
            int month = Convert.ToInt32(args[0]);
            int day = Convert.ToInt32(args[1]);

            // Check if the date falls in the Spring Season (March 20 to June 20)
            if ((month == 3 && day >= 20 && day <= 31) ||
                (month == 4 && day >= 1 && day <= 30) ||  
                (month == 5 && day >= 1 && day <= 31) ||  
                (month == 6 && day >= 1 && day <= 20))    
            {
                Console.WriteLine("It's a Spring Season.");
            }
            else
            {
                Console.WriteLine("Not a Spring Season.");
            }
        }
    }
}
