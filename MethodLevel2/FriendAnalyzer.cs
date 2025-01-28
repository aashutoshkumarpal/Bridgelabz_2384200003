 using System;

namespace MethodLevel2
{
    public class FriendAnalyzer
    {
	
		public static void Input()
        {
            string[] names = { "Amar", "Akbar", "Anthony" };
            int[] ages = new int[3];
            double[] heights = new double[3];

            Console.WriteLine("Enter the age and height of Amar, Akbar, and Anthony:");

            // Input ages and heights
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"{names[i]}'s Age (in years): ");
                ages[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write($"{names[i]}'s Height (in cm): ");
                heights[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Find the youngest and tallest friend
            string youngest = FindYoungest(names, ages);
            string tallest = FindTallest(names, heights);

            // Display the results
            Console.WriteLine($"\nThe youngest friend is {youngest}.");
            Console.WriteLine($"The tallest friend is {tallest}.");
        }
        // Method to find the youngest friend
        public static string FindYoungest(string[] names, int[] ages)
        {
            int youngestIndex = 0;
            for (int i = 1; i < ages.Length; i++)
            {
                if (ages[i] < ages[youngestIndex])
                {
                    youngestIndex = i;
                }
            }
            return names[youngestIndex];
        }

        // Method to find the tallest friend
        public static string FindTallest(string[] names, double[] heights)
        {
            int tallestIndex = 0;
            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] > heights[tallestIndex])
                {
                    tallestIndex = i;
                }
            }
            return names[tallestIndex];
        }
    }

   
}
