using System;
using System.Collections.Generic;

namespace IsStringPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a sentence to check wheter palindrome or not");
            string textToEvaluate = Console.ReadLine();
            Console.WriteLine(IsPalindrome(textToEvaluate) ? "Is palindrome" : "Is not Palindrome");
            Console.ReadLine();
        }

        public static bool IsPalindrome(string word)
        {
            char[] chars = word.ToLower().ToCharArray();
            Stack<int> pile = new Stack<int>();
            int isMiddle = (chars.Length % 2 == 1) ? (chars.Length / 2) : (chars.Length / 2) - 1;
            bool odd = chars.Length % 2 == 1;

            for (int i = 0; i < chars.Length; i++)
            {
                if (i <= isMiddle)
                {
                    pile.Push(chars[i]);
                }

                if (i > isMiddle)
                {
                    if (odd)
                    {
                        pile.Pop();
                        odd = false;
                    }
                    if (chars[i] != pile.Pop())
                    {
                        return false;
                    }
                }

            }

            return true;
        }  
    }
}
