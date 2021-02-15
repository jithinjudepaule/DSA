using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RemoveVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "hello world";
            RemoveVowels(testString);
        }

        static void RemoveVowels(string testString)
        {

            testString = Regex.Replace(testString, "[aeiouAEIOU]", "");
            Console.WriteLine(testString);
            //List<char> charList = new List<char>();
            //for (int i = 0; i < testString.Length; i++)
            //{
            //    if (testString[i]=='a' || testString[i] == 'o' || testString[i] == 'i' || testString[i] == 'o' || testString[i] == 'u' || testString[i]=='e' )
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        charList.Add(testString[i]);
            //    }
            //}

            //string vowelsRemoved = "";

            //foreach (var item in charList)
            //{
            //    vowelsRemoved = vowelsRemoved + item;
            //}

            //Console.WriteLine(vowelsRemoved);
        }
    }
}
