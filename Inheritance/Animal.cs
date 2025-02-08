using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Base class Animal
    public class Animal
    {
        string Name { get; set; } // Private properties, should be made public or provide getters
        int Age { get; set; } // Same as above

        // Constructor to initialize Name and Age
        public Animal(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        // Virtual method to be overridden by derived classes
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    // Derived class Dog inheriting from Animal
    public class Dog : Animal
    {
        // Constructor calling base class constructor
        public Dog(string Name, int Age) : base(Name, Age)
        {
        }

        // Overriding MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Dog Barks");
        }
    }

    // Derived class Cat inheriting from Animal
    public class Cat : Animal
    {
        // Constructor calling base class constructor
        public Cat(string Name, int Age) : base(Name, Age)
        {
        }

        // Overriding MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Cat Meows");
        }
    }

    // Derived class Bird inheriting from Animal
    public class Bird : Animal
    {
        // Constructor calling base class constructor
        public Bird(string Name, int Age) : base(Name, Age)
        {
        }

        // Overriding MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Bird chirps");
        }
    }
}
