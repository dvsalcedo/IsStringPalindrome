using System;

namespace IsStringPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            bool isPalindrome = true;
            string textToEvaluate = "tet";
            char[] chars = textToEvaluate.ToCharArray();
            int[] NumberOfAppears = new int[char.ToUpper('z') - char.ToUpper('a') + 1];

            for (int i=0; i<chars.Length; i++)
            {
                int numberOfChar = char.ToUpper(chars[i]) - 64;
                if((char.ToUpper('a') - 64) <= numberOfChar && numberOfChar <= (char.ToUpper('z')-64))
                {
                    NumberOfAppears[numberOfChar]++;
                }
                else
                {
                    NumberOfAppears[numberOfChar] = -1;
                }
            }

            bool odd = false;
            foreach (var number in NumberOfAppears)
            {
                if(number % 2 == 1)
                {
                    if (odd)
                    {
                        isPalindrome = false;
                        break;
                    }
                    odd = true;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("Is Palindrome");
            }
            else
            {
                Console.WriteLine("Is NOT Palindrome");
            }

        }
    }
}
