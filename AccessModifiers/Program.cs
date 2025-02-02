using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Ques which you want to run from 1 to 4 ");
            int ques = Convert.ToInt32(Console.ReadLine());

            CallingAllClass callingAllClass = new CallingAllClass();    

            switch (ques)
            {
                case 1:
                    callingAllClass.CallingStudent();
                    break;
                case 2:
                    callingAllClass.CallingBook();
                    break;
                case 3:
                    callingAllClass.CallingBankAccount();
                    break;
                case 4:
                    callingAllClass.CallingEmployee();
                    break;
                default:
                    Console.WriteLine("Inavlid Input");
                    break;
            
            }
        }
    }
}
