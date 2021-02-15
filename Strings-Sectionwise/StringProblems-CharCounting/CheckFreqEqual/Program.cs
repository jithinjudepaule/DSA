using System;
using System.Collections.Generic;

namespace CheckFreqEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "xyyyzz";
            if (checkIfFreqEqual(testString))
            {
                Console.WriteLine("Freq equal");
            }
            else
            {
                Console.WriteLine("Freq not equal");
            }
            ;
        }

        private static bool checkIfFreqEqual(string testString)
        {
            int[] alphabetsCount = new int[26];

            for (int i = 0; i < testString.Length; i++)
            {
                alphabetsCount[testString[i] - 'a']++;
            }

            if (AllSame(alphabetsCount))
            {
                return true;
            }
            for (int i = 0; i < alphabetsCount.Length; i++)
            {
                if (alphabetsCount[i]>0)
                {
                    alphabetsCount[i]--;
                    if (AllSame(alphabetsCount))
                    {
                        return true;
                    }
                    alphabetsCount[i]++;
                }
            }

            return false;

           
        }

        private static bool AllSame(int[] alphabetsCount)
        {
            int same=0;
            for (int i = 0; i < alphabetsCount.Length; i++)
            {
                if (alphabetsCount[i]>0)
                {
                    same = alphabetsCount[i];
                    break;
                }
            }

            for (int i = 0; i < alphabetsCount.Length; i++)
            {
                if (alphabetsCount[i]>0 && alphabetsCount[i]!=same)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
