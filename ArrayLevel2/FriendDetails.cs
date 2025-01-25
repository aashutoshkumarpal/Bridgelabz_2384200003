using System;

namespace ArrayLevel2
{
    class FriendDetails
    {
        // Program to find the youngest and tallest friends among Amar, Akbar, and Anthony
        static void FindYoungestAndTallest()
        {
            // Arrays to store age and height of the three friends
            int[] ages = new int[3];
            double[] heights = new double[3];

            // Input details for the three friends
            Console.WriteLine("Enter details for Amar, Akbar, and Anthony:");

            // Loop to take user input for age and height
            for (int i = 0; i < 3; i++)
            {
                string friendName = i == 0 ? "Amar" : i == 1 ? "Akbar" : "Anthony";

                // Input age
                while (true)
                {
                    Console.Write($"Enter age of {friendName}: ");
                    try
                    {
                        ages[i] = Convert.ToInt32(Console.ReadLine());
                        if (ages[i] < 0)
                        {
                            Console.WriteLine("Age cannot be negative. Please enter a valid age.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for age.");
                    }
                }

                // Input height
                while (true)
                {
                    Console.Write($"Enter height of {friendName} (in meters): ");
                    try
                    {
                        heights[i] = Convert.ToDouble(Console.ReadLine());
                        if (heights[i] < 0)
                        {
                            Console.WriteLine("Height cannot be negative. Please enter a valid height.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for height.");
                    }
                }
            }

            // Find the youngest and the tallest
            int youngestIndex = 0;
            double tallestIndex = 0;

            // Loop to find the youngest and tallest
            for (int i = 1; i < 3; i++)
            {
                if (ages[i] < ages[youngestIndex]) // Find the youngest
                {
                    youngestIndex = i;
                }

                if (heights[i] > heights[tallestIndex]) // Find the tallest
                {
                    tallestIndex = i;
                }
            }

            // Display the results
            Console.WriteLine($"\nThe youngest friend is { (youngestIndex == 0 ? "Amar" : youngestIndex == 1 ? "Akbar" : "Anthony") } with age {ages[youngestIndex]}.");
            Console.WriteLine($"The tallest friend is { (tallestIndex == 0 ? "Amar" : tallestIndex == 1 ? "Akbar" : "Anthony") } with height {heights[tallestIndex]} meters.");
        }
    }
}
