using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsLevel1
{
    internal class Person
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Default Constructor
        public Person()
        {
            Name = "Unknown";
            Age = 0;
        }

        // Parameterized Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Copy Constructor (Cloning another Person object)
        public Person(Person other)
        {
            Name = other.Name;
            Age = other.Age;
        }

        // Method to Display Person Details
        public void DisplayPersonDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }
}
