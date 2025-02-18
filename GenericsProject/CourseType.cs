using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProject
{
    // Abstract base class for different course types
    abstract class CourseType
    {
        public string CourseName { get; set; }
        public string Instructor { get; set; }

        public CourseType(string courseName, string instructor)
        {
            CourseName = courseName;
            Instructor = instructor;
        }

        public abstract void ShowEvaluationMethod();
    }

    // Concrete course type: Exam-based course
    class ExamCourse : CourseType
    {
        public int TotalMarks { get; set; }

        public ExamCourse(string courseName, string instructor, int totalMarks)
            : base(courseName, instructor)
        {
            TotalMarks = totalMarks;
        }

        public override void ShowEvaluationMethod()
        {
            Console.WriteLine($"Course: {CourseName}, Instructor: {Instructor}, Evaluation: Exam (Total Marks: {TotalMarks})");
        }
    }

    // Concrete course type: Assignment-based course
    class AssignmentCourse : CourseType
    {
        public int TotalAssignments { get; set; }

        public AssignmentCourse(string courseName, string instructor, int totalAssignments)
            : base(courseName, instructor)
        {
            TotalAssignments = totalAssignments;
        }

        public override void ShowEvaluationMethod()
        {
            Console.WriteLine($"Course: {CourseName}, Instructor: {Instructor}, Evaluation: Assignments (Total: {TotalAssignments})");
        }
    }

    // Generic class to manage courses (Ensures only CourseType or its derived classes can be used)
    class Course<T> where T : CourseType
    {
        private List<T> courseList = new List<T>();

        public void AddCourse(T course)
        {
            courseList.Add(course);
        }

        public void DisplayCourses()
        {
            foreach (var course in courseList)
            {
                course.ShowEvaluationMethod();
            }
        }
    }

    // Main Program
    class Program4
    {
        static void Main()
        {
            // Managing Exam-based courses
            Course<ExamCourse> examCourses = new Course<ExamCourse>();
            examCourses.AddCourse(new ExamCourse("Mathematics", "Dr. Smith", 100));
            examCourses.AddCourse(new ExamCourse("Physics", "Dr. Johnson", 80));

            // Managing Assignment-based courses
            Course<AssignmentCourse> assignmentCourses = new Course<AssignmentCourse>();
            assignmentCourses.AddCourse(new AssignmentCourse("Programming", "Prof. Davis", 5));
            assignmentCourses.AddCourse(new AssignmentCourse("Data Science", "Prof. Lee", 6));

            // Display all courses
            Console.WriteLine("Exam-based Courses:");
            examCourses.DisplayCourses();

            Console.WriteLine("\nAssignment-based Courses:");
            assignmentCourses.DisplayCourses();
        }
    }
