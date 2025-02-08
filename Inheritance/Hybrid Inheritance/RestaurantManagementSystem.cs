using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Hybrid_Inheritance
{
    // Interface defining worker duties
    interface Worker
    {
        void PerformDuties();
    }

    // Base class
    class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Person(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public virtual void DisplayRole()
        {
            Console.WriteLine("General Person");
        }
    }

    // Subclass Chef implementing Worker interface
    class Chef : Person, Worker
    {
        public string Specialty { get; set; }

        public Chef(string name, int id, string specialty)
            : base(name, id)
        {
            Specialty = specialty;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("Chef specializing in: " + Specialty);
        }

        public void PerformDuties()
        {
            Console.WriteLine("Chef is cooking gourmet dishes.");
        }
    }

    // Subclass Waiter implementing Worker interface
    class Waiter : Person, Worker
    {
        public int TablesAssigned { get; set; }

        public Waiter(string name, int id, int tablesAssigned)
            : base(name, id)
        {
            TablesAssigned = tablesAssigned;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("Waiter handling " + TablesAssigned + " tables.");
        }

        public void PerformDuties()
        {
            Console.WriteLine("Waiter is serving food and taking orders.");
        }
    }
}
