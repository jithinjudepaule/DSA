using System;
using System.Collections.Generic;

namespace ConsecutiveVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "our article is in queue ";
            RemoveVowels(testString);
        }

        static void RemoveVowels(string testString)
        {

            List<char> vowelsList = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            List<char> vowelsRemoved = new List<char>();

            Console.WriteLine(testString[0]);
            for (int i = 1; i < testString.Length; i++)
            {
                if (vowelsList.Contains(testString[i]) &&  vowelsList.Contains(testString[i-1]))
                {

                    continue;
                }

                else
                {
                    Console.WriteLine(testString[i]);
                }
            }

           
        }
    }
}
