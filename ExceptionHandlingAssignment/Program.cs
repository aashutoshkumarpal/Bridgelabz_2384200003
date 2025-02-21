using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExecptionHandlingAssignment
{
    internal class Program
    {
        public static void SwitchCases()
        {
            Console.WriteLine("Enter which question you want to execute from 1 to 10");
            int ques = Convert.ToInt32(Console.ReadLine());

            switch ( ques )
            {
                case 1:
                    FileHandler fileHandler = new FileHandler();
                    fileHandler.ReadFile();
                    break;
                case 2:
                    DivideByZero divideByZero = new DivideByZero();
                    divideByZero.InputMethod();
                    break;
                case 3:
                    CustomExecption customExecption = new CustomExecption();
                    customExecption.InputMethod();
                    break;
                case 4:
                    ArrayHandler arrayHandler = new ArrayHandler();
                    arrayHandler.InputMethod();
                    break;
                case 5:
                    ReadFirstLine readFirstLine = new ReadFirstLine();
                    readFirstLine.InputMethod();
                    break;
                case 6:
                    InterestCalculator interestCalculator = new InterestCalculator();
                    interestCalculator.InputMethod();
                    break;
                case 7:
                    FinallyBlock finallyBlock = new FinallyBlock();
                    finallyBlock.InputMethod();
                    break; 
                case 8:
                    PropagatingExceptions propagatingExceptions = new PropagatingExceptions();
                    propagatingExceptions.InputMethod();
                    break;
                case 9:
                    NestedTryCatch nestedTryCatch = new NestedTryCatch();
                    nestedTryCatch.InputMethod();
                    break;
                case 10:
                    BankAccount bankAccount = new BankAccount();
                    bankAccount.InputMethod();
                    break;
                default:
                    Console.WriteLine("Invalid Question");
                    break;

            }
        }
        static void Main(string[] args)
        {
            SwitchCases();
        }
    }
}
