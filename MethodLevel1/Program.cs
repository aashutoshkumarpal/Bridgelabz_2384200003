using System;

namespace MethodLevel1
{
	class Program{
		static void Switchcases(){
	
			Console.WriteLine("Enter which question you want to run (1 to 12):");
			int ques = Convert.ToInt32(Console.ReadLine());

		switch (ques)
		{
        case 1:
			Console.WriteLine("To Calculate Simple interest");
            SimpleInterestCalculator obj1 = new SimpleInterestCalculator();
			obj1.InputMethod();
            break;
		case 2:
			Console.WriteLine("To Calculate Handshake");
			HandshakeCalculator obj2 = new HandshakeCalculator();
			obj2.InputMethod();
			break;
		case 3:
		    Console.WriteLine("To Calculate Handshake2");
			HandshakeCalculator2 obj3 = new HandshakeCalculator2();
			obj3.InputMethod();
			break;
		case 4:
		    Console.WriteLine("To Calculate Perimeter of Triangle");
			TriangularParkRun obj4 = new TriangularParkRun();
			obj4.InputMethod();
			break;
		case 5:
		    Console.WriteLine("To Check the Number");
			NumberSignChecker obj5 = new NumberSignChecker();
			obj5.InputMethod();
			break;
		case 6:
		    Console.WriteLine("To Check the Month for Spring Season");
			SpringSeasonChecker obj6 = new SpringSeasonChecker();
			obj6.InputMethod();
			break;
		case 7:
			Console.WriteLine("To Calculate the Sum of Natural Number");
			NaturalNumberSum obj7 = new NaturalNumberSum();
			obj7.InputMethod();
			break;
		case 8:
			Console.WriteLine("To Calculate the Smallest and Largest Number");
			SmallestAndLargest obj8 = new SmallestAndLargest();
			obj8.InputMethod();
			break;
		case 9:
			Console.WriteLine("To Calculate the Quotient and Remainder");
			QuotientAndRemainder obj9 = new QuotientAndRemainder();
			obj9.InputMethod();
			break;
		case 10:
			Console.WriteLine("To Calculate the Chocolates");
			ChocolatesDivision obj10 = new ChocolatesDivision();
			obj10.InputMethod();
			break;
		case 11:
			Console.WriteLine("To Calculate the Wind Chill temperature");
			WindChillCalculator obj11 = new WindChillCalculator();
			obj11.InputMethod();
			break;
		case 12:
			Console.WriteLine("To Calculate the Trigonometric Functions");
			TrigonometricFunctions obj12 = new TrigonometricFunctions();
			obj12.InputMethod();
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