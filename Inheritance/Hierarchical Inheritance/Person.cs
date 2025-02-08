using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Hierarchical_Inheritance
{
    // Base class
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void DisplayRole()
        {
            Console.WriteLine("General Person");
        }
    }

    // Subclass Teacher
    class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string name, int age, string subject)
            : base(name, age)
        {
            Subject = subject;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("Teacher of Subject: " + Subject);
        }
    }

    // Subclass Student
    class Student : Person
    {
        public string Grade { get; set; }

        public Student(string name, int age, string grade)
            : base(name, age)
        {
            Grade = grade;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("Student in Grade: " + Grade);
        }
    }

    // Subclass Staff
    class Staff : Person
    {
        public string Position { get; set; }

        public Staff(string name, int age, string position)
            : base(name, age)
        {
            Position = position;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("Staff Position: " + Position);
        }
    }
}
