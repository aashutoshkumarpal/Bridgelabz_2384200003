using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceVsClassVariable
{
    internal class Course
    {
        // Instance Variables
        public string CourseName { get; set; }
        public int Duration { get; set; } // in weeks
        public double Fee { get; set; }

        // Class Variable (Shared among all instances)
        private static string instituteName = "Global Tech Institute";

        // Constructor to Initialize Course
        public Course(string courseName, int duration, double fee)
        {
            CourseName = courseName;
            Duration = duration;
            Fee = fee;
        }

        // Instance Method to Display Course Details
        public void DisplayCourseDetails()
        {
            Console.WriteLine($"Institute: {instituteName}");
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Duration: {Duration} weeks");
            Console.WriteLine($"Fee: Rs {Fee:F2}");
            Console.WriteLine();
        }

        // Class Method to Update Institute Name
        public static void UpdateInstituteName(string newName)
        {
            instituteName = newName;
            Console.WriteLine($"Institute Name Updated to: {instituteName}");
            Console.WriteLine();
        }
    }
}
