using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    internal class Program
    {
        public static void SwitcheCases()
        {
            Console.WriteLine("Enter which you want to execute 1 to 7 ");
            int ques = Convert.ToInt32(Console.ReadLine());

            switch (ques) 
            { 
                case 1:
                    BubbleSort obj1 = new BubbleSort();
                    obj1.InputMethod();
                    break;
                case 2:
                    EmployeeIDSorter obj2 = new EmployeeIDSorter();
                    obj2.InputMethod();
                    break;
                case 3:
                    BookPriceSorter obj3 = new BookPriceSorter();
                    obj3.InputMethod();
                    break;
                case 4:
                    ProductPriceSorter obj4= new ProductPriceSorter();
                    obj4.InputMethod();
                    break;
                case 5:
                    ExamScoreSorter obj5 = new ExamScoreSorter();
                    obj5.InputMethod();
                    break;
                case 6:
                    JobApplicantSorter obj6 = new JobApplicantSorter();
                    obj6.InputMethod();
                    break;
                case 7:
                    StudentAgeSorter obj7 = new StudentAgeSorter();
                    obj7.InputMethod();
                    break;
                default:
                    Console.WriteLine("Invalid question number");
                    break;
            }
        }
        static void Main(string[] args)
        {
            SwitcheCases();
        }
    }
}
