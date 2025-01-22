using System;

namespace new_project
{
    // Class to calculate and display the average percentage in PCM subjects
    class AveragePercentage
    {
        public void Average()
        {
            // Define marks for Math, Physics, and Chemistry
            int Math = 94;
            int Physics = 95;
            int Chemistry = 96;

            // Calculate the average marks
            int result = (Math + Physics + Chemistry) / 3;

            // Output the result
            Console.WriteLine($"Sam’s average mark in PCM is {result}");
        }
    }
}
