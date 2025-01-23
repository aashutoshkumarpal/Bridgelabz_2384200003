using System;

namespace Assignment_No3Level3
{
	class Program{
		static void Switchcases(){
	
			Console.WriteLine("Enter which question you want to run (1 to 11):");
			int ques = Convert.ToInt32(Console.ReadLine());

		switch (ques)
		{
        case 1:
            ArmstrongChecker obj1 = new ArmstrongChecker();
			obj1.CheckArmstrongNumber();
            break;
		case 2:
			DigitCounter obj2 = new DigitCounter();
			obj2.CountDigits();
			break;
		case 3:
			HarshadNumberChecker obj3 = new HarshadNumberChecker();
			obj3.CheckHarshadNumber();
			break;
		case 4:
			DayOfWeekCalculator obj4 = new DayOfWeekCalculator();
			obj4.CalculateDayOfWeek(args);
			break;
		case 5:
			AbundantNumberChecker obj5 = new AbundantNumberChecker();
			obj5.CheckAbundantNumber();
			break;
		case 6:
			Calculator obj6 = new Calculator();
			obj6.PerformCalculation();
			break;
        default:
            Console.WriteLine("Invalid question number. Please select between 1 and 11.");
            break;
		}
	}
	static void Main(string[] args)
	{
    Switchcases();
	}
	}
}