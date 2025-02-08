using Inheritance.Hierarchical_Inheritance;
using Inheritance.Hybrid_Inheritance;
using Inheritance.Multilevel_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myDog = new Dog("Titan", 3);
            Animal myCat = new Cat("kitty", 2);
            Animal myBird = new Bird("Tweety", 1);

            // Demonstrating polymorphism
            myDog.MakeSound(); // Dog barks
            myCat.MakeSound(); // Cat meows
            myBird.MakeSound(); // Bird chirps




            Employee manager = new Manager(101, "Alice", 75000, 10);
            Employee developer = new Developer(102, "Bob", 60000, "C#");
            Employee intern = new Intern(103, "Charlie", 20000, "6 months");

            manager.DisplayDetails();
            Console.WriteLine();
            developer.DisplayDetails();
            Console.WriteLine();
            intern.DisplayDetails();




            Vehicle[] vehicles = new Vehicle[]
            {
            new Car(220, "Petrol", 5),
            new Truck(120, "Diesel", 10000),
            new Motorcycle(180, "Petrol", true)
            };

            foreach (Vehicle v in vehicles)
            {
                v.DisplayInfo();
                Console.WriteLine();
            }



            Author book = new Author("C# Programming", 2022, "John Doe", "Expert in software development");
            book.DisplayInfo();



            Thermostat thermostat = new Thermostat(101, "On", 22.5);
            thermostat.DisplayStatus();




            Order order = new Order(1001, DateTime.Now);
            Console.WriteLine(order.GetOrderStatus());

            ShippedOrder shippedOrder = new ShippedOrder(1002, DateTime.Now, "XYZ123456");
            Console.WriteLine(shippedOrder.GetOrderStatus());

            DeliveredOrder deliveredOrder = new DeliveredOrder(1003, DateTime.Now, "ABC789123", DateTime.Now.AddDays(3));
            Console.WriteLine(deliveredOrder.GetOrderStatus());




            Course course = new Course("Introduction to Programming", 6);
            course.DisplayDetails();

            Console.WriteLine();

            OnlineCourse onlineCourse = new OnlineCourse("Web Development", 8, "Udemy", true);
            onlineCourse.DisplayDetails();

            Console.WriteLine();

            PaidOnlineCourse paidOnlineCourse = new PaidOnlineCourse("Machine Learning", 12, "Coursera", true, 299.99, 20);
            paidOnlineCourse.DisplayDetails();


            BankAccount generalAccount = new BankAccount(1001, 5000);
            generalAccount.DisplayAccountType();

            Console.WriteLine();

            SavingsAccount savings = new SavingsAccount(1002, 10000, 3.5);
            savings.DisplayAccountType();

            Console.WriteLine();

            CheckingAccount checking = new CheckingAccount(1003, 7000, 2000);
            checking.DisplayAccountType();

            Console.WriteLine();

            FixedDepositAccount fixedDeposit = new FixedDepositAccount(1004, 15000, 12);
            fixedDeposit.DisplayAccountType();



            Person generalPerson = new Person("John Doe", 40);
            generalPerson.DisplayRole();

            Console.WriteLine();

            Teacher teacher = new Teacher("Alice Smith", 35, "Mathematics");
            teacher.DisplayRole();

            Console.WriteLine();

            Student student = new Student("Bob Johnson", 16, "10th Grade");
            student.DisplayRole();

            Console.WriteLine();

            Staff staff = new Staff("Charlie Brown", 45, "Administrator");
            staff.DisplayRole();


            Chef chef = new Chef("Gordon Ramsay", 101, "French Cuisine");
            chef.DisplayRole();
            chef.PerformDuties();

            Console.WriteLine();

            Waiter waiter = new Waiter("John Doe", 202, 5);
            waiter.DisplayRole();
            waiter.PerformDuties();


            ElectricVehicle ev = new ElectricVehicle(150, "Tesla Model 3", 75);
            ev.DisplayInfo();
            ev.Charge();

            Console.WriteLine();

            PetrolVehicle pv = new PetrolVehicle(180, "Ford Mustang", 60);
            pv.DisplayInfo();
            pv.Refuel();
        }
    }
}
