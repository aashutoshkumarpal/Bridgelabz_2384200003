using System;
using System.Collections.Generic;

namespace ObjectModeling
{
    public class Faculty
    {
        public string Name { get; }
        public string Specialization { get; }

        public Faculty(string name, string specialization)
        {
            Name = name;
            Specialization = specialization;
        }

        public void DisplayFaculty()
        {
            Console.WriteLine($"   Faculty: {Name}, Specialization: {Specialization}");
        }
    }

    public class Department
    {
        public string DepartmentName { get; }
        private List<Faculty> facultyMembers;

        public Department(string departmentName)
        {
            DepartmentName = departmentName;
            facultyMembers = new List<Faculty>();
        }

        public void AddFaculty(Faculty faculty)
        {
            facultyMembers.Add(faculty);
        }

        public void DisplayDepartment()
        {
            Console.WriteLine($"\nDepartment: {DepartmentName}");
            if (facultyMembers.Count == 0)
            {
                Console.WriteLine("   No faculty members in this department.");
            }
            else
            {
                foreach (var faculty in facultyMembers)
                {
                    faculty.DisplayFaculty();
                }
            }
        }
    }

    public class University
    {
        public string UniversityName { get; }
        private List<Department> departments;
        private List<Faculty> faculties;

        public University(string universityName)
        {
            UniversityName = universityName;
            departments = new List<Department>();
            faculties = new List<Faculty>();
        }

        public void AddDepartment(string departmentName)
        {
            departments.Add(new Department(departmentName));
        }

        public void AddFaculty(Faculty faculty)
        {
            faculties.Add(faculty);
        }

        public Department GetDepartment(string departmentName)
        {
            return departments.Find(d => d.DepartmentName == departmentName);
        }

        public void DisplayUniversity()
        {
            Console.WriteLine($"\nUniversity: {UniversityName}");

            Console.WriteLine("\nDepartments:");
            if (departments.Count == 0)
            {
                Console.WriteLine("   No departments available.");
            }
            else
            {
                foreach (var department in departments)
                {
                    department.DisplayDepartment();
                }
            }

            Console.WriteLine("\nFaculty Members (Independent):");
            if (faculties.Count == 0)
            {
                Console.WriteLine("   No independent faculty members.");
            }
            else
            {
                foreach (var faculty in faculties)
                {
                    faculty.DisplayFaculty();
                }
            }
        }

        ~University()
        {
            Console.WriteLine($"University {UniversityName} is being deleted, along with all departments.");
        }
    }

    public class UniversityDemo
    {
        public void InputMethod()
        {
            // Creating a university
            University myUniversity = new University("Tech University");

            // Adding departments (Composition: Departments belong to the university)
            myUniversity.AddDepartment("Computer Science");
            myUniversity.AddDepartment("Mechanical Engineering");

            // Creating faculty members (Aggregation: Faculty members exist independently)
            Faculty profAlice = new Faculty("Alice", "AI & Machine Learning");
            Faculty profBob = new Faculty("Bob", "Mechanical Systems");
            Faculty profCharlie = new Faculty("Charlie", "Cybersecurity");

            // Adding faculty to the university (they exist independently)
            myUniversity.AddFaculty(profAlice);
            myUniversity.AddFaculty(profBob);

            // Assigning faculty to departments
            myUniversity.GetDepartment("Computer Science").AddFaculty(profAlice);
            myUniversity.GetDepartment("Computer Science").AddFaculty(profCharlie);
            myUniversity.GetDepartment("Mechanical Engineering").AddFaculty(profBob);

            // Displaying university details
            myUniversity.DisplayUniversity();

            // Simulating deletion of the university
            myUniversity = null;
            GC.Collect(); // Force garbage collection to demonstrate destructor
        }
    }
}
