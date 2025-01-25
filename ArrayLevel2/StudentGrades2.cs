using System;

namespace ArrayLevel2
{
    class StudentGrades2
    {
        
        public void CalculateGrades()
        {
            // Take input for the number of students
            Console.Write("Enter the number of students: ");
            int numStudents = Convert.ToInt32(Console.ReadLine());

            // Create a 2D array to store marks (rows = students, columns = subjects)
            double[,] marks = new double[numStudents, 3]; 
            double[] percentages = new double[numStudents]; 
            string[] grades = new string[numStudents]; 

            // Take input for marks of students
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"\nEnter marks for student {i + 1}:");

                // Input marks for Physics, Chemistry, and Maths with validation
                bool validInput = false;
                while (!validInput)
                {
                    Console.Write("Physics marks: ");
                    marks[i, 0] = Convert.ToDouble(Console.ReadLine());
                    if (marks[i, 0] < 0)
                    {
                        Console.WriteLine("Marks can't be negative. Please enter a valid number.");
                        continue;
                    }

                    Console.Write("Chemistry marks: ");
                    marks[i, 1] = Convert.ToDouble(Console.ReadLine());
                    if (marks[i, 1] < 0)
                    {
                        Console.WriteLine("Marks can't be negative. Please enter a valid number.");
                        continue;
                    }

                    Console.Write("Maths marks: ");
                    marks[i, 2] = Convert.ToDouble(Console.ReadLine());
                    if (marks[i, 2] < 0)
                    {
                        Console.WriteLine("Marks can't be negative. Please enter a valid number.");
                        continue;
                    }

                    validInput = true; 
                }

                // Calculate percentage for each student
                double totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
                percentages[i] = (totalMarks / 300) * 100;

                // Calculate grade based on percentage
                if (percentages[i] >= 75)
                    grades[i] = "A";
                else if (percentages[i] >= 60)
                    grades[i] = "B";
                else if (percentages[i] >= 50)
                    grades[i] = "C";
                else if (percentages[i] >= 40)
                    grades[i] = "D";
                else
                    grades[i] = "F";
            }

            // Display the marks, percentages, and grades for each student
            Console.WriteLine("\nStudent Details:");

            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"\nStudent {i + 1}:");
                Console.WriteLine($"Physics Marks: {marks[i, 0]}");
                Console.WriteLine($"Chemistry Marks: {marks[i, 1]}");
                Console.WriteLine($"Maths Marks: {marks[i, 2]}");
                Console.WriteLine($"Percentage: {percentages[i]:0.00}%");
                Console.WriteLine($"Grade: {grades[i]}");
            }
        }
    }
}
