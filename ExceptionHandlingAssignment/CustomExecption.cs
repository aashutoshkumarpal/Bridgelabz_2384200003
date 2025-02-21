using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecptionHandlingAssignment
{
    public class InvalidAgeExecption : Exception
    {
        public InvalidAgeExecption(string msg) : base(msg) { }
    }
    public class CustomExecption
    {
        public void Validate(int age)
        {
            if(age < 18)
            {
                throw new InvalidAgeExecption("Age must be above 18");
            }
            Console.WriteLine("Access grantedb!");
        }
        public void InputMethod()
        {
            try
            {
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Validate(age);
            }
            catch (InvalidAgeExecption ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input! Please enter a valid number.");
            }
        }
    }
}
