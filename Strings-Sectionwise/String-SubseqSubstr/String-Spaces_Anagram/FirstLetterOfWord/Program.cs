using System;
using System.Collections.Generic;

namespace FirstLetterOfWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "happy   coding";

            PrintLetters(testString);
           


        }

        private static void PrintLetters(string testString)
        {
            List<char> characters = new List<char>();
            Console.WriteLine(testString[0]);
            for (int i = 1; i < testString.Length; i++)
            {
                if (testString[i]==' ' && (i+1)<testString.Length && testString[i+1]!=' ')
                {
                    Console.WriteLine(testString[i+1]);
                }
            }
            
        }
    }
}
