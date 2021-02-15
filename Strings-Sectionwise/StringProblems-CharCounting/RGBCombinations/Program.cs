using System;
using System.Collections.Generic;

namespace RGBCombinations
{
    class Program
    {
        static HashSet<string> hashSet = new HashSet<string>();
        static void Main(string[] args)
        {
           
            int n = 4;
            char[] charSet = new char[] { 'r', 'g', 'b' };

            FindCombinations(n, charSet);
        }

        private static void FindCombinations(int n, char[] charSet)
        {
            string combination = "";
            string[] combiArray = new string[3];
            for (int i = 0; i < charSet.Length; i++)
            {
                combination = combination + charSet[i];
            }

            for (int i = 0; i < charSet.Length; i++)
            {
                if (combination.Length < n)
                {
                    combiArray[i] = combination + charSet[i];
                }
            }

            for (int i = 0; i < combiArray.Length; i++)
            {
                int low = 0; int high = combiArray[0].Length - 1;
            FindPermutations(combiArray[i], low, high);
        }
            Console.WriteLine(hashSet.Count);
        }

        private static void FindPermutations(string combiArray, int low, int high)
        {
            if (low==high)
            {
                hashSet.Add(combiArray);
                Console.WriteLine(combiArray);
            }
            else
            {
                for (int i = low; i <= high; i++)
                {
                    combiArray=swap(combiArray, low, i);
                    FindPermutations(combiArray, low + 1, high);
                    combiArray=swap(combiArray, low, i);

                }
            }
        }

        private static string swap(string combiArray, int low, int i)
        { 
        
        char[] charArray = combiArray.ToCharArray();

        char temp = combiArray[low];
            charArray[low] = combiArray[i];
            charArray[i] = temp;

            return new string(charArray);

        }
    }
}
