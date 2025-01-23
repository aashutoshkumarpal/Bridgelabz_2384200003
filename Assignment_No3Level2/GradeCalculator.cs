using System;

namespace Assignment_No3Level2
{
    class GradeCalculator
    {
        public void CalculateGrade()
        {
            // Take input marks for Physics, Chemistry, and Maths
            Console.Write("Enter marks for Physics: ");
            double physicsMarks = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter marks for Chemistry: ");
            double chemistryMarks = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter marks for Maths: ");
            double mathsMarks = Convert.ToDouble(Console.ReadLine());

            // Calculate total and percentage
            double totalMarks = physicsMarks + chemistryMarks + mathsMarks;
            double percentage = (totalMarks / 300) * 100; // As total marks are 300

            // Calculate the grade based on percentage
            string grade = "";
            string remarks = "";

            if (percentage >= 90)
            {
                grade = "A";
                remarks = "Excellent";
            }
            else if (percentage >= 75)
            {
                grade = "B";
                remarks = "Good";
            }
            else if (percentage >= 50)
            {
                grade = "C";
                remarks = "Average";
            }
            else
            {
                grade = "D";
                remarks = "Poor";
            }

            // Output the results
            Console.WriteLine("\n---- Result ----");
            Console.WriteLine($"Total Marks: {totalMarks} / 300");
            Console.WriteLine($"Percentage: {percentage}%");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Remarks: {remarks}");
        }
    }
}
