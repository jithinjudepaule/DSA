using System;

namespace StringSameFreqBut1
{
    /// <summary>
    /// Check if a string has all characters with same frequency with one variation allowed
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "aabbcd";
            if (CheckFreq(testString))
            {
                Console.WriteLine("Same Frequency");
            }
            else
            {
                Console.WriteLine("Not same frequency");
            }
        
        }

        private static bool CheckFreq(string testString)
        {
            int[] alphabetsCount = new int[26];
            int smallest = 0;
            int smallestIndex = 0;
            for (int i = 0; i < testString.Length; i++)
            {
                alphabetsCount[testString[i] -'a']++; 
            }

            for (int i = 0; i < alphabetsCount.Length; i++)
            {
                if (alphabetsCount[i]>0)
                {
                    smallest = alphabetsCount[i];
                    break;
                }
            }
            for (int i = 0; i < alphabetsCount.Length; i++)
            {
                if (alphabetsCount[i]>0)
                {
                    if (smallest>alphabetsCount[i])
                    {
                        smallest = alphabetsCount[i];
                        smallestIndex = i;
                    }
                }
               
               
            }

            alphabetsCount[smallestIndex]--;
            if (AllSame(alphabetsCount))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private static bool AllSame(int[] alphabetsCount)
        {
            int same = 0;
            for (int i = 0; i < alphabetsCount.Length; i++)
            {
                if (alphabetsCount[i] > 0)
                {
                    same = alphabetsCount[i];
                    break;
                }
            }

            for (int i = 0; i < alphabetsCount.Length; i++)
            {
                if (alphabetsCount[i]>0 && same != alphabetsCount[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
