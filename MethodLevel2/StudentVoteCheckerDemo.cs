using System;

namespace MethodLevel2
{
    public class StudentVoteChecker
    {
        // Method to check if a student can vote
        public static bool CanStudentVote(int age)
        {
            if (age < 0) // Validate age for negative numbers
            {
                return false;
            }
            return age >= 18; // Check if age is 18 or above
        }
    }

    class StudentVoteCheckerDemo
    {
        public void InputMethod()
        {
            int[] studentAges = new int[10]; // Array to store ages of 10 students

            Console.WriteLine("Enter the ages of 10 students:");

            for (int i = 0; i < studentAges.Length; i++)
            {
                Console.Write($"Enter age for student {i + 1}: ");
                studentAges[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nVoting Eligibility Results:");
            for (int i = 0; i < studentAges.Length; i++)
            {
                bool canVote = StudentVoteChecker.CanStudentVote(studentAges[i]);
                if (studentAges[i] < 0)
                {
                    Console.WriteLine($"Student {i + 1}: Invalid age entered.");
                }
                else
                {
                    Console.WriteLine($"Student {i + 1}: Age {studentAges[i]} - Can Vote: {canVote}");
                }
            }
        }
    }

}
