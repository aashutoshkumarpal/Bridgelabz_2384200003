using System;

namespace MethodLevel1
{
    class HandshakeCalculator2
    {
        public void InputMethod()
        {
            // Take user input for the number of students
            Console.Write("Enter the number of students: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            // Calculate the maximum number of handshakes
            int maxHandshakes = CalculateHandshakes(numberOfStudents);

            // Display the result
            Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is {maxHandshakes}.");
        }

        // Method to calculate the maximum number of handshakes using the combination formula
        public static int CalculateHandshakes(int numberOfStudents)
        {
            return (numberOfStudents * (numberOfStudents - 1)) / 2;
        }
    }
}
