using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    public class StringAlgorithms
    {
        public bool IsUppercase(string s)
        {
            return s.All(char.IsUpper);
        }

        public bool IsLowercase(string s)
        {
            return s.All(char.IsLower);
        }

        public bool IsPasswordComplex(string password)
        {
            return password.Any(char.IsUpper) && 
                password.Any(char.IsLower) && 
                password.Any(char.IsDigit);
        }

        public string NormalizeString(string input)
        {
            return input.ToLower().Trim().Replace(",", "");
        }

        public string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            StringBuilder reversed = new StringBuilder(input.Length);

            for(int i = input.Length -1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }

            return reversed.ToString();
        }

        public string ReverseString2 (string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            char[] arr = input.ToCharArray(); 
            Array.Reverse(arr);

            return new string(arr);
        }

        //Code Challenge - Reverse Each word (attempt)
        //public string ReverseEachWord(string input)
        //{
        //    if (string.IsNullOrEmpty(input)) return input;
        //
        //    var result = String.Empty;
        //
        //    var stringArray = input.Split(" ");
        //
        //    foreach(var word in stringArray)
        //    {
        //        result += ReverseString(word) + " ";
        //    }
        //
        //    return result.Remove(result.Length - 1, 1);
        //}

        //Code Challenge - Reverse Each word (solution)
        public string ReverseEachWord(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            StringBuilder result = new StringBuilder();
            var wordArray = input.Split(" ");
            for (int i = 0; i < wordArray.Length; i++)
            {
                result.Append(ReverseString(wordArray[i]));
                if (i != wordArray.Length - 1) {
                    result.Append(' ');
                };
            }
            return result.ToString();
        }
    }
}
