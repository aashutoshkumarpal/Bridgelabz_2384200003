using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceVsClassVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which question do you want to run from 1 to 3");
            int ques = Convert.ToInt32(Console.ReadLine());

            CallingAllClass callingAllClass = new CallingAllClass();    

            switch (ques)
            {
                case 1:
                    callingAllClass.CallingProduct();
                    break;
                case 2:
                    callingAllClass.CallingCourse();
                    break;
                case 3:
                    callingAllClass.CallingVehicle();
                    break;
                default:
                    Console.WriteLine(" Invalid Input ");
                    break;
            }
        }
    }
}
