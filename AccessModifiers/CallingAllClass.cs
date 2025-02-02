using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class CallingAllClass
    {
        public void CallingStudent()
        {
            // Creating a Student object
            Student student1 = new Student(101, "Aashutosh", 8.5);
            student1.DisplayStudentDetails();

            // Modifying CGPA using setter
            student1.SetCGPA(9.0);
            Console.WriteLine("Updated CGPA: " + student1.GetCGPA());
            Console.WriteLine();

            // Creating a PostgraduateStudent object
            PostgraduateStudent pgStudent = new PostgraduateStudent(201, "Ankit", 9.2, "Artificial Intelligence");
            pgStudent.DisplayPostgraduateDetails();
        }

        public void CallingBook()
        {
            // Creating a Physical Book Object
            Book book1 = new Book("978-3-16-148410-0", "Yhe Wings of fire", "Dr. Abdul Kalam");
            book1.DisplayBookDetails();

            // Modifying Author using setter method
            book1.SetAuthor("Fitzgerald");
            Console.WriteLine("Updated Author: " + book1.GetAuthor());
            Console.WriteLine();

            // Creating an E-Book Object
            EBook ebook1 = new EBook("978-0-123-45678-9", "Abc", "Aashutosh", 5.6, "PDF");
            ebook1.DisplayEBookDetails();
        }

        public void CallingBankAccount()
        {
            // Creating a Bank Account Object
            BankAccount account1 = new BankAccount("123456789", "Aashutosh", 5000);
            account1.DisplayAccountDetails();

            // Performing Transactions
            account1.Deposit(1500);
            account1.Withdraw(2000);
            Console.WriteLine("Updated Balance: $" + account1.GetBalance());
            Console.WriteLine();

            // Creating a Savings Account Object
            SavingsAccount savings1 = new SavingsAccount("987654321", "Ankit", 10000, 3.5);
            savings1.DisplaySavingsAccountDetails();
        }

        public void CallingEmployee()
        {
            // Creating an Employee Object
            Employee emp1 = new Employee(101, "Finance", 50000);
            emp1.DisplayEmployeeDetails();

            // Updating Salary
            emp1.UpdateSalary(55000);
            Console.WriteLine("Updated Salary: $" + emp1.GetSalary());
            Console.WriteLine();

            // Creating a Manager Object
            Manager mgr1 = new Manager(201, "IT", 75000, "10");
            mgr1.DisplayManagerDetails();
        }
    }
}
