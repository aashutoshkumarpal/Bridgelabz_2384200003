using System;

namespace MethodLevel2
{
	class Program{
		static void Switchcases(){
	
			Console.WriteLine("Enter which question you want to run (1 to 12):");
			int ques = Convert.ToInt32(Console.ReadLine());

		switch (ques)
		{
        case 1:
			
            FactorCalculator obj1 = new FactorCalculator();
			obj1.InputMethod();
            break;
		case 2:
			
			NaturalNumberSum obj2 = new NaturalNumberSum();
			obj2.InputMethod();
			break;
		case 3:
		    
			LeapYearChecker obj3 = new LeapYearChecker();
			obj3.InputMethod();
			break;
		case 4:
		    
			UnitConverterDemo demo = new UnitConverterDemo();
            demo.InputMethod();
			break;
		case 5:
		    UnitConverterDemo2 demo = new UnitConverterDemo2();
            demo.InputMethod();
			break;
		case 6:
			UnitConverterDemo3 demo = new UnitConverterDemo3();
            demo.InputMethod();
			break;
		case 7:
			StudentVoteCheckerDemo demo = new StudentVoteCheckerDemo();
            demo.InputMethod();
			break;
		case 8:
			NumberCheckerDemo demo = new NumberCheckerDemo();
            demo.InputMethod();
			break;
		case 9:
			FriendAnalyzer demo = new FriendAnalyzer();
			demo.Input();
			break;
		case 10:
			BMIAnalyzer demo = new BMIAnalyzer();
			demo.InputAndProcess();
			break;
		case 11:
			QuadraticEquationSolver demo = new QuadraticEquationSolver();
			demo.InputAndSolve();
			break;
		case 12:
			RandomValueAnalyzer demo = new RandomValueAnalyzer();
			demo.InputAndAnalyze();
			break;
        default:
            Console.WriteLine("Invalid question number. Please select between 1 and 12.");
            break;
		}
	}
	static void Main(string[] args)
	{
    Switchcases();
	}
	}
}