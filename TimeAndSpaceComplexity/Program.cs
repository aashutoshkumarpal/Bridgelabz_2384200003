using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAndSpaceComplexity
{
    internal class Program
    {
        static void SwitchCases()
        {
            Console.WriteLine("Enter the Question which you want to execute from 1 to 5");
            int ques = int.Parse(Console.ReadLine());

            switch (ques) 
            { 
                case 1:
                    Ques1 ques1 = new Ques1();
                    ques1.InputMethod();
                    break;
                case 2:
                    Ques2 ques2 = new Ques2();
                    ques2.InputMethod();
                    break;
                case 3:
                    Ques3 ques3 = new Ques3();
                    ques3.InputMethod();
                    break;
                case 4:
                    Ques4 ques4 = new Ques4();
                    ques4.InputMethod();
                    break;
                case 5:
                    Ques5 ques5 = new Ques5();
                    ques5.InputMethod();
                    break;
                default:
                    Console.WriteLine("Invalid question ");
                    break;
            }
        }
        static void Main(string[] args)
        {
            SwitchCases();
        }
    }
}
