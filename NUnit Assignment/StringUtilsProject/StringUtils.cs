using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringUtilsProject
{
    public class StringUtils
    {
        // Reverses the given string.
        public string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Checks if the given string is a palindrome.
        public bool IsPalindrome(string str)
        {
            string reversed = Reverse(str);
            return string.Equals(str, reversed, StringComparison.OrdinalIgnoreCase);
        }

        // Converts the given string to uppercase.
        public string ToUpperCase(string str) => str.ToUpper();
    }
}
