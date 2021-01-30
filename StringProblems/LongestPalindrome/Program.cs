using System;

namespace LongestPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string palindromeString = "aaaabbaa";
            findLongestPalindrome(palindromeString);
        }

        private static void findLongestPalindrome(string palindromeString)
        {
            string s = "";
            for (int i = palindromeString.Length-1; i >=0; i--)
            {
                s = s + palindromeString[i];
            }
            if (s==palindromeString)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
                Console.WriteLine(s);
            }
        }
    }
}
