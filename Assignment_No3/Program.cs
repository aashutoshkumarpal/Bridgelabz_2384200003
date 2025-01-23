using System;

namespace Assignment_No3
{
	class Program{
		static void Switchcases(){
	
			Console.WriteLine("Enter which question you want to run (1 to 18):");
			int ques = Convert.ToInt32(Console.ReadLine());

		switch (ques)
		{
        case 1:
            DivisibilityChecker obj1 = new DivisibilityChecker();
			obj1.CheckDivisibilityBy5();
            break;
		case 2:
			NumberChecker obj2 = new NumberChecker();
			obj2.CheckIfFirstIsSmallest();
			break;
		case 3:
			NumberChecker2 obj3 = new NumberChecker2();
			obj3.CheckLargestNumber();
			break;
		case 4:
			NaturalNumber obj4 = new NaturalNumber();
			obj4.CheckAndSumNaturalNumbers();
			break;
		case 5:
			VotingEligibility obj5 = new VotingEligibility();
			obj5.CheckVotingEligibility();
			break;
		case 6:
			NumberPositiveNegativeZero obj6 = new NumberPositiveNegativeZero();
			obj6.CheckNumber();
			break;
		case 7:
			SpringSeason obj7 = new SpringSeason();
			obj7.
			break;
		case 8:
			RocketLaunchCountdown obj8 = new RocketLaunchCountdown();
			obj8.StartCountdown();
			break;
		case 9:
			RocketLaunchCountdown2 obj9 = new RocketLaunchCountdown2();
			obj9.StartCountdown();
			break;
		case 10:
			SumOfNumbers obj10 =new SumOfNumbers();
			obj10.CalculateSum();
			break;
		case 11:
			SumOfNumbers2 obj11 =new SumOfNumbers2();
			obj11.CalculateSum();
			break;
		case 12:
			NaturalNumberSum obj12 = new NaturalNumberSum();
			obj12.FindSumAndCompare();
			break;
		case 13:
			NaturalNumberSum2 obj13 = new NaturalNumberSum2();
			obj13.FindSumAndCompare();
			break;
		case 14:
			FactorialCalculator obj14 = new FactorialCalculator();
			obj14.Factorial();
			break;
		case 15:
			FactorialCalculator2 obj15 = new FactorialCalculator2();
			obj15.Factorial();
			break;
		case 16:
			OddEvenNumbers obj16 = new OddEvenNumbers();
			obj16.PrintOddEven();
			break;
		case 17:
			EmployeeBonus obj17 = new EmployeeBonus();
			obj17.CalculateBonus();
			break;
		case 18:
			MultiplicationTable obj18 = new MultiplicationTable();
			obj18.GenerateTable();
			break;
        default:
            Console.WriteLine("Invalid question number. Please select between 1 and 18.");
            break;
		}
	}
	static void Main(string[] args)
	{
    Switchcases();
	}
	}
}