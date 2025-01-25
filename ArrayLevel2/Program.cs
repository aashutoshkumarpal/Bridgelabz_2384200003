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
            EmployeeBonus Obj1 = new EmployeeBonus();
            Obj1.CalculateBonus();
            break;
		case 2:
			FriendDetails obj2 = new FriendDetails();
			obj2.FindYoungestAndTallest();
			break;
		case 3:
			MultiplicationTable obj3 = new MultiplicationTable();
			obj3.PrintTable();
			break;
		case 4:
			NumberDigits obj4 = new NumberDigits();
			obj4.FindLargestAndSecondLargest();
			break;
		case 5:
			ReverseNumber obj5 = new ReverseNumber();
			obj5.ReverseDigits();
			break;
		case 6:
			BMI obj6 = new BMI();
			obj6.CalculateBMI();
			break;
		case 7:
			BMIUsing2DArray obj7 = new BMIUsing2DArray();
            obj7.CalculateBMI();
			break;
		case 8:
			StudentGrades obj8 = new StudentGrades();
            obj8.CalculateGrades();
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