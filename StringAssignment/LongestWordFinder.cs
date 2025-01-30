using System;

namespace StringAssignment
{
    class LongestWordFinder
    {
        public void FindLongestWord()
        {
            Console.WriteLine("Enter the String");
			string? str = Console.ReadLine() + " ";
			string longest = "";
			string word = "";
		
		
			if(string.IsNullOrEmpty(str)){
			Console.WriteLine("Inavalid Input");
			return;
			}
		
			foreach(char c in str){
				if (c != ' '){
				word += c;
				}
				else{
					if(word.Length > longest.Length){
						longest = word;
						word = "";
					}
				}
			}
		
			Console.WriteLine($" Longest word in string: {longest}");
        }
    }
}
