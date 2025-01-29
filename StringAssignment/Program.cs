using System;

namespace StringAssignment
{
	class Program{
		static void Switchcases(){
	
			Console.WriteLine("Enter which question you want to run (1 to 12):");
			int ques = Convert.ToInt32(Console.ReadLine());

		switch (ques)
		{
        case 1:
            CountVowelAndConsonant obj1 = new CountVowelAndConsonant();
			obj1.Count();
            break;
		case 2:
			ReverseString obj2 = new ReverseString();
			obj2.Reverse();
			break;
		case 3:
			Palindrome obj3 = new Palindrome();
			obj3.checkPalindrome();
			break;
		case 4:
		    Duplicate obj4 = new Duplicate();
			obj4.RemoveDuplicate();
			break;
		case 5:
			 LongestWordFinder obj5 = new LongestWordFinder();
			  obj5.FindLongestWord();
			break;
		case 6:
			SubstringCounter obj6 = new SubstringCounter();
			obj6.InputMethod();
			break;
		case 7:
			ToggleCaseProgram obj7 = new ToggleCaseProgram();
			obj7.InputMethod();
			break;
		case 8:
			StringComparer obj8 = new StringComparer();
			obj8.InputMethod();
			break;
		case 9:
			MostFrequentCharacterFinder obj9 = new MostFrequentCharacterFinder();
			obj9.InputMethod();
			break;
		case 10:
			RemoveCharacterProgram obj10 = new RemoveCharacterProgram();
			obj10.InputMethod();
			break;
		case 11:
			AnagramChecker obj11 = new AnagramChecker();
			obj11.InputMethod();
			break;
		case 12:
			WordReplacer obj12 = new WordReplacer();
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