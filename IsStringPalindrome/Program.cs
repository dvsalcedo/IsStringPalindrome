using System;

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
            bool isPalindrome = true;
            char[] chars = word.Replace(" ", "").ToCharArray();
            int[] NumberOfAppears = new int[char.ToUpper('z') - char.ToUpper('a') + 1];

            for (int i = 0; i < chars.Length; i++)
            {
                int numberOfChar = char.ToUpper(chars[i]) - 64;
                if ((char.ToUpper('a') - 64) <= numberOfChar && numberOfChar <= (char.ToUpper('z') - 64))
                {
                    NumberOfAppears[numberOfChar]++;
                }

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
