using System;

namespace IsStringPalindrome
{
    class Program
    {

        const int LIMITCHARS = 128; //128 o 256 ASCCI

        static void Main(string[] args)
        {
            Console.WriteLine("Write a sentence to check wheter palindrome or not");
            string textToEvaluate = Console.ReadLine();
            Console.WriteLine(IsPalindrome(textToEvaluate) ? "Is palindrome" : "Is not Palindrome");
            Console.ReadLine();
        }

        public static bool IsPalindrome(string word)
        {
            bool isPalindrome = true;
            char[] chars = word.Replace(" ", "").ToCharArray();
            int[] NumberOfAppears = new int[LIMITCHARS];

            for (int i = 0; i < chars.Length; i++)
            {
                NumberOfAppears[(int)chars[i]]++;
            }

            bool odd = false;
            foreach (var number in NumberOfAppears)
            {
                if (number % 2 == 1)
                {
                    if (odd) //Two or more odds
                    {
                        isPalindrome = false;
                        break;
                    }
                    odd = true;
                }
            }

            return isPalindrome;
        }
    }
}
