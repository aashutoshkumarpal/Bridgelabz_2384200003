using System;
using System.Collections.Generic;

namespace ObjectModeling
{
    public class Course
    {
        public string CourseName { get; }
        public Professor AssignedProfessor { get; private set; }
        private List<Student> enrolledStudents;

        public Course(string courseName)
        {
            CourseName = courseName;
            enrolledStudents = new List<Student>();
        }

        public void AssignProfessor(Professor professor)
        {
            AssignedProfessor = professor;
            professor.AssignCourse(this);
        }

        public void EnrollStudent(Student student)
        {
            if (!enrolledStudents.Contains(student))
            {
                enrolledStudents.Add(student);
                student.EnrollInCourse(this);
            }
        }

        public void DisplayCourseInfo()
        {
            Console.WriteLine($"\nCourse: {CourseName}");
            Console.WriteLine($"   Professor: {(AssignedProfessor != null ? AssignedProfessor.Name : "Not Assigned")}");
            Console.WriteLine("   Enrolled Students:");

            if (enrolledStudents.Count == 0)
            {
                Console.WriteLine("   No students enrolled.");
            }
            else
            {
                foreach (var student in enrolledStudents)
                {
                    Console.WriteLine($"   - {student.Name}");
                }
            }
        }
    }

    public class Student
    {
        public string Name { get; }
        private List<Course> enrolledCourses;

        public Student(string name)
        {
            Name = name;
            enrolledCourses = new List<Course>();
        }

        public void EnrollInCourse(Course course)
        {
            if (!enrolledCourses.Contains(course))
            {
                enrolledCourses.Add(course);
            }
        }

        public void DisplayEnrolledCourses()
        {
            Console.WriteLine($"\nStudent: {Name}");
            if (enrolledCourses.Count == 0)
            {
                Console.WriteLine("   No courses enrolled.");
            }
            else
            {
                foreach (var course in enrolledCourses)
                {
                    Console.WriteLine($"   - {course.CourseName} (Professor: {(course.AssignedProfessor != null ? course.AssignedProfessor.Name : "Not Assigned")})");
                }
            }
        }
    }

    public class Professor
    {
        public string Name { get; }
        private List<Course> assignedCourses;

        public Professor(string name)
        {
            Name = name;
            assignedCourses = new List<Course>();
        }

        public void AssignCourse(Course course)
        {
            if (!assignedCourses.Contains(course))
            {
                assignedCourses.Add(course);
            }
        }

        public void DisplayAssignedCourses()
        {
            Console.WriteLine($"\nProfessor: {Name}");
            if (assignedCourses.Count == 0)
            {
                Console.WriteLine("   No courses assigned.");
            }
            else
            {
                foreach (var course in assignedCourses)
                {
                    Console.WriteLine($"   - {course.CourseName}");
                }
            }
        }
    }

    public class University
    {
        public string UniversityName { get; }
        private List<Student> students;
        private List<Professor> professors;
        private List<Course> courses;

        public University(string universityName)
        {
            UniversityName = universityName;
            students = new List<Student>();
            professors = new List<Professor>();
            courses = new List<Course>();
        }

        public void AddStudent(Student student)
        {
            if (!students.Contains(student))
            {
                students.Add(student);
            }
        }

        public void AddProfessor(Professor professor)
        {
            if (!professors.Contains(professor))
            {
                professors.Add(professor);
            }
        }

        public void AddCourse(Course course)
        {
            if (!courses.Contains(course))
            {
                courses.Add(course);
            }
        }

        public void DisplayUniversityInfo()
        {
            Console.WriteLine($"\nUniversity: {UniversityName}");

            Console.WriteLine("\nCourses:");
            if (courses.Count == 0)
            {
                Console.WriteLine("   No courses available.");
            }
            else
            {
                foreach (var course in courses)
                {
                    course.DisplayCourseInfo();
                }
            }

            Console.WriteLine("\nStudents:");
            if (students.Count == 0)
            {
                Console.WriteLine("   No students enrolled.");
            }
            else
            {
                foreach (var student in students)
                {
                    student.DisplayEnrolledCourses();
                }
            }

            Console.WriteLine("\nProfessors:");
            if (professors.Count == 0)
            {
                Console.WriteLine("   No professors assigned.");
            }
            else
            {
                foreach (var professor in professors)
                {
                    professor.DisplayAssignedCourses();
                }
            }
        }
    }

    public class UniversityDemo
    {
        public void InputMethod()
        {
            // Creating a university
            University myUniversity = new University("Tech University");

            // Creating professors
            Professor profSmith = new Professor("Dr. Smith");
            Professor profJohnson = new Professor("Dr. Johnson");

            // Creating courses
            Course mathCourse = new Course("Mathematics");
            Course csCourse = new Course("Computer Science");

            // Assigning professors to courses
            mathCourse.AssignProfessor(profSmith);
            csCourse.AssignProfessor(profJohnson);

            // Creating students
            Student alice = new Student("Alice");
            Student bob = new Student("Bob");

            // Enrolling students in courses
            mathCourse.EnrollStudent(alice);
            mathCourse.EnrollStudent(bob);
            csCourse.EnrollStudent(alice);

            // Adding entities to the university
            myUniversity.AddProfessor(profSmith);
            myUniversity.AddProfessor(profJohnson);
            myUniversity.AddStudent(alice);
            myUniversity.AddStudent(bob);
            myUniversity.AddCourse(mathCourse);
            myUniversity.AddCourse(csCourse);

            // Display university data
            myUniversity.DisplayUniversityInfo();
        }
    }
}
