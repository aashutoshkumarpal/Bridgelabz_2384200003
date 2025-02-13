using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortAStackUsingRecursion stack = new SortAStackUsingRecursion();

            stack.push(3);
            stack.push(1);
            stack.push(4);
            stack.push(2);
            stack.push(5);

            Console.WriteLine("Original Stack:");
            stack.PrintStack();

            stack.SortStack();

            Console.WriteLine("Sorted Stack:");
            stack.PrintStack();
        }
    }
}
