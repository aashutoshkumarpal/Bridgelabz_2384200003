using System;

namespace AssignmentNo3Level3
{
    class Calculator
    {
        public void PerformCalculation()
        {
            // Get the first number
            Console.Write("Enter the first number: ");
            double first = Convert.ToDouble(Console.ReadLine());

            // Get the second number
            Console.Write("Enter the second number: ");
            double second = Convert.ToDouble(Console.ReadLine());

            // Get the operator
            Console.Write("Enter an operator (+, -, *, /): ");
            string op = Console.ReadLine();

            // Perform the operation based on the operator
            switch (op)
            
                case "+":
                    Console.WriteLine($"Result: {first} + {second} = {first + second}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {first} - {second} = {first - second}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {first} * {second} = {first * second}");
                    break;
                case "/":
                    if (second != 0) // Avoid division by zero
                    {
                        Console.WriteLine($"Result: {first} / {second} = {first / second}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator. Please use +, -, *, or /.");
                    break;
            }
        }
    }
   
}
