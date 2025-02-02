using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    // Base Class: Student
    public class Student
    {
        // Public member: Accessible anywhere
        public int RollNumber { get; set; }

        // Protected member: Accessible in derived classes
        protected string Name;

        // Private member: Accessible only within the class
        private double CGPA;

        // Constructor to initialize student details
        public Student(int rollNumber, string name, double cgpa)
        {
            RollNumber = rollNumber;
            Name = name;
            CGPA = cgpa;
        }

        // Public Method to Set CGPA
        public void SetCGPA(double cgpa)
        {
            if (cgpa >= 0.0 && cgpa <= 10.0)
            {
                CGPA = cgpa;
            }
            else
            {
                Console.WriteLine("Invalid CGPA! Must be between 0.0 and 10.0.");
            }
        }

        // Public Method to Get CGPA
        public double GetCGPA()
        {
            return CGPA;
        }

        // Public Method to Display Student Details
        public void DisplayStudentDetails()
        {
            Console.WriteLine($"Roll Number: {RollNumber}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"CGPA: {CGPA:F2}");
            Console.WriteLine();
        }
    }

    // Derived Class: PostgraduateStudent
    public class PostgraduateStudent : Student
    {
        public string ResearchTopic { get; set; }

        // Constructor using base class constructor
        public PostgraduateStudent(int rollNumber, string name, double cgpa, string researchTopic)
            : base(rollNumber, name, cgpa)
        {
            ResearchTopic = researchTopic;
        }

        // Method to Display Postgraduate Student Details
        public void DisplayPostgraduateDetails()
        {
            Console.WriteLine($"Roll Number: {RollNumber}");
            Console.WriteLine($"Name: {Name}");  // Accessible due to 'protected' modifier
            Console.WriteLine($"Research Topic: {ResearchTopic}");
            Console.WriteLine($"CGPA: {GetCGPA():F2}");  // Accessing private member using public method
            Console.WriteLine();
        }
    }
}
