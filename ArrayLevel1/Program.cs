using System;

namespace ArrayLevel1
{
	class Program{
		static void Switchcases(){
	
			Console.WriteLine("Enter which question you want to run (1 to 10):");
			int ques = Convert.ToInt32(Console.ReadLine());

		switch (ques)
		{
        case 1:
            VoteValidity Obj1 = new VoteValidity();
            Obj1.CheckVoteValidity();
            break;
		case 2:
			EvenOddAndCompare obj2 = new EvenOddAndCompare();
			obj2.ProcessArray();
			break;
		case 3:
			MultiplicationTable obj3 = new MultiplicationTable();
			obj3.PrintTable();
			break;
		case 4:
			NumberArrayProcessor obj4 = new NumberArrayProcessor();
			obj4.ProcessNumbers();
			break;
		case 5:
			MultiplicationTable6TO9 obj5 = new MultiplicationTable6TO9();
			obj5.GenerateTable();
			break;
		case 6:
			FootballPayerMeanHeight obj6 = new FootballPayerMeanHeight();
			obj6.CalculateMean();
			break;
		case 7:
			OddEvenArrayProcessor obj7 = new OddEvenArrayProcessor();
            obj7.OddEvenArrays();
			break;
		case 8:
			FactorFinder obj8 = new FactorFinder();
            obj8.FindFactors();
			break;
		case 9:
			TwoDArrayToOneDarray obj9 = new TwoDArrayToOneDarray();
            obj9.CreateAndCopyArray();
			break;
		case 10:
			FizzBuzzProgram obj10 = new FizzBuzzProgram();
            obj10.FizzBuzz();
			break;
        default:
            Console.WriteLine("Invalid question number. Please select between 1 and 10.");
            break;
		}
	}
	static void Main(string[] args)
	{
    Switchcases();
	}
	}
}