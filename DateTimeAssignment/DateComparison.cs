using System;

namespace DateTimeAssignment
{
    class DateComparison
    {
        // Method to compare two user-entered dates
        public void CompareDates()
        {
            // Prompt the user to enter the first date in yyyy-MM-dd format
            Console.Write("Enter first date (yyyy-MM-dd): ");
            
            // Try parsing the user input into a DateTime object
            if (DateTime.TryParse(Console.ReadLine(), out DateTime firstDate))
            {
                // Prompt the user to enter the second date
                Console.Write("Enter second date (yyyy-MM-dd): ");
                
                // Try parsing the second input into a DateTime object
                if (DateTime.TryParse(Console.ReadLine(), out DateTime secondDate))
                {
                    // Compare the two dates using CompareTo method
                    int comparisonResult = firstDate.CompareTo(secondDate);
                    
                    // Determine the relationship between the two dates
                    if (comparisonResult < 0)
                    {
                        Console.WriteLine("The first date is before the second date.");
                    }
                    else if (comparisonResult > 0)
                    {
                        Console.WriteLine("The first date is after the second date.");
                    }
                    else
                    {
                        Console.WriteLine("Both dates are the same.");
                    }
                }
                else
                {
                    // Display an error if the second date format is invalid
                    Console.WriteLine("Invalid second date format.");
                }
            }
            else
            {
                // Display an error if the first date format is invalid
                Console.WriteLine("Invalid first date format.");
            }
        }
    }
}
