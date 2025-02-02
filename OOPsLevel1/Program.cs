using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsLevel1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter which question you want to run ?");
            int ques = Convert.ToInt32(Console.ReadLine());

            CallingAllClass callingAllClass = new CallingAllClass();

            switch(ques)
            {
                case 1:
                    callingAllClass.callingBook();
                    break;
                case 2:
                    callingAllClass.callingCircle();
                    break;
                case 3:
                    callingAllClass.callingPerson();
                    break;
                case 4:
                    callingAllClass.callingHotelBooking();
                    break;
                case 5:
                    callingAllClass.CallingLibaryBookSystem();
                    break;
                case 6:
                    callingAllClass.CallingCarRental();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}
