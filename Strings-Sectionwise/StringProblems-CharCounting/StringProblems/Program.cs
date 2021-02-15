using System;
using System.Collections.Generic;
using System.Linq;

namespace StringProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToReverse = "Hello World !";
            ReverseString(stringToReverse);
        }

        private static void ReverseString(string stringToReverse)
        {
            string[] stringArray= stringToReverse.Split(' ');
            string[] reversedString = new string[stringArray.Length];
            int j = 0;
            for (int i = stringArray.Length-1; i >=0 ; i--)
            {
                reversedString[j] = stringArray[i];
                j++;
            }
            Console.WriteLine(string.Join(' ',reversedString));
        }
    }
}