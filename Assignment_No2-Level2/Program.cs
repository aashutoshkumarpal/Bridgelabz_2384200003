using System;

namespace Assignment_No2
{
	class Program{
		static void Switchcases(){
	
			Console.WriteLine("Enter which question you want to run (1 to 12):");
			int ques = Convert.ToInt32(Console.ReadLine());

		switch (ques)
		{
        case 1:
            QuotientRemainderCalculator Obj1 = new QuotientRemainderCalculator();
            Obj1.CalculateQuotientRemainder();
            break;
		case 2:
			MultiOperation obj2 = new MultiOperation();
			obj2.multipleOperation();
			break;
		case 3:
			DoubleOpt obj3 = new DoubleOpt();
			obj3.PerformOperations();
			break;
		case 4:
			TemperatureConversion obj4 = new TemperatureConversion();
			obj4.ConvertTemperature();
			break;
		case 5:
			TemperatureConversion2 obj5 = new TemperatureConversion2();
			obj5.ConvertFahrenheitToCelsius();
			break;
		case 6:
			IncomeCalculator obj6 = new IncomeCalculator();
			obj6.CalculateTotalIncome();
			break;
		case 7:
			NumberSwapper obj7 = new NumberSwapper();
            obj7.SwapNumbers();
			break;
		case 8:
			JourneyDetails obj8 = new JourneyDetails();
            obj8.GetJourneyDetails();
			break;
		case 9:
			AthleteRounds obj9 = new AthleteRounds();
            obj9.CalculateRounds();
			break;
		case 10:
			ChocolateDivider obj10 = new ChocolateDivider();
            obj10.DivideChocolates();
			break;
		case 11:
			SimpleInterestCalculator obj11 = new SimpleInterestCalculator();
            obj11.CalculateSimpleInterest();
			break;
		case 12:
			WeightConverter obj12 = new WeightConverter();
            obj12.ConvertWeight();
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