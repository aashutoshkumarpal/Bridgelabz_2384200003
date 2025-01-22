using System;

namespace Assignment_No2
{
    class MultiOperation
    {
        public void multipleOperation()
        {
            // Take three numbers as input from the user
            Console.Write("Enter the a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the b: ");
            int b = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Enter the c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            // Calculate the operations
			
            int result = a + b * c;
			int result2 = a * b + c;
			int result3 = c + a / b;
			int result4 = a % b + c;

            // Display the results
            Console.WriteLine($"The results of Int Operations are {result},{result2},{result3}, and {result4} ");
        }
    }
}
