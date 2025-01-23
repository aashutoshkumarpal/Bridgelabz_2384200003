using System;

namespace Assignment_No3Level2
{
	class Program{
		static void Switchcases(){
	
			Console.WriteLine("Enter which question you want to run (1 to 11):");
			int ques = Convert.ToInt32(Console.ReadLine());

		switch (ques)
		{
        case 1:
            LeapYearChecker obj1 = new LeapYearChecker();
			obj1.CheckLeapYear();
            break;
		case 2:
			LeapYearChecker2 obj2 = new LeapYearChecker2();
			obj2.CheckLeapYear();
			break;
		case 3:
			GradeCalculator obj3 = new GradeCalculator();
			obj3.CalculateGrade();
			break;
		case 4:
			PrimeNumberChecker obj4 = new PrimeNumberChecker();
			obj4.CheckPrimeNumber();
			break;
		case 5:
			FizzBuzzProgram obj5 = new FizzBuzzProgram();
			obj5.PlayFizzBuzz();
			break;
		case 6:
			FizzBuzzProgramWhile obj6 = new FizzBuzzProgramWhile();
			obj6.PlayFizzBuzzWithWhile();
			break;
		case 7:
			FriendsComparison obj7 = new FriendsComparison();
			obj7.FindYoungestAndTallest();
			break;
		case 8:
			GreatestFactorFinder obj8 = new GreatestFactorFinder();
			obj8.FindGreatestFactor();
			break;
		case 9:
			PowerCalculator obj9 = new PowerCalculator();
			obj9.CalculatePower();
			break;
		case 10:
			FactorFinder obj10 =new FactorFinder();
			obj10.FindFactors();
			break;
		case 11:
			MultiplesFinder obj11 =new MultiplesFinder();
			obj11.FindMultiplesBelow100();
			break;
		case 12:
			BMICalculator obj12 = new BMICalculator();
			obj12.CalculateBMI();
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