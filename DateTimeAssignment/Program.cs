using System;

namespace DateTimeAssignment
{
	class Program{
		static void Switchcases(){
	
			Console.WriteLine("Enter which question you want to run (1 to 12):");
			int ques = Convert.ToInt32(Console.ReadLine());

		switch (ques)
		{
        case 1:
            TimeZoneDisplay obj1 = new TimeZoneDisplay();
			obj1.DisplayTimeInTimeZones();
            break;
		case 2:
			DateArithmetic obj2 = new DateArithmetic();
			obj2.PerformDateArithmetic();
			break;
		case 3:
			DateFormatting obj3 = new DateFormatting();
			obj3.DisplayDateFormats();
			break;
		case 4:
		    DateComparison obj4 = new DateComparison();
			obj4.CompareDates();
			break;
		case 5:
			 LongestWordFinder obj5 = new LongestWordFinder();
			  obj5.FindLongestWord();
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