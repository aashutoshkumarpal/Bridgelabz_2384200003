using System;

namespace new_project
{
    // Class to calculate the distribution of pens among students
    class PenDistribution
    {
        public void Distribution()
        {
            // Define the total number of pens and students
            int pen = 10;
            int student = 3;

            // Calculate how many pens each student gets and the remaining pens
            int penPerStu = pen / student; // Division for pens per student
            int rem = pen % student;       // Remainder for pens not distributed

            // Display the result
            Console.WriteLine($"The Pen Per Student is {penPerStu} and the remaining pen not distributed is {rem}");
        }
    }
}
