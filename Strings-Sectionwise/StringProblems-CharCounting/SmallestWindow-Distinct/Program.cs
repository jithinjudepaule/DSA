using System;
using System.Collections.Generic;

namespace SmallestWindow_Distinct
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "aba";
            FindDistinctSubstring(testString);
        }

        private static void FindDistinctSubstring(string testString)
        {
            int[] distinctPatArray = new int[256];
            int[] testStringArray = new int[256];
            HashSet<char> hashset = new HashSet<char>();
            for (int i = 0; i < testString.Length; i++)
            {
                if (!hashset.Contains(testString[i]))
                {
                    hashset.Add(testString[i]);
                }
            }

            string distinctChars = "";
            foreach (char item in hashset)
            {
                distinctChars = distinctChars + item;
            }

            for (int i = 0; i < distinctChars.Length; i++)
            {
                distinctPatArray[distinctChars[i]]++;
            }

            int start = 0; int startIndex = -1; int lenWindow = 0;
            int minLenWindow = int.MaxValue; int count = 0;

            for (int i = 0; i < testString.Length; i++)
            {
                testStringArray[testString[i]]++;
                
                if (testStringArray[testString[i]]<= distinctPatArray[testString[i]])
                {
                    count++;
                }

                if (count==distinctChars.Length)
                {
                    while (testStringArray[testString[start]]> distinctPatArray[testString[start]]||
                       distinctPatArray[testString[start]]==0)
                    {
                        if (testStringArray[testString[start]] > distinctPatArray[testString[start]])
                        {
                            testStringArray[testString[start]]--;
                        }
                        start++;
                    }

                    lenWindow = i - start + 1;

                    if (minLenWindow>lenWindow)
                    {
                        minLenWindow = lenWindow;
                        startIndex = start;
                    }
                }
            }

            if (startIndex==-1)
            {
                Console.WriteLine("No Index found");
            }

            else
            {
                Console.WriteLine($"Smallest distinct substring is {testString.Substring(startIndex,minLenWindow)}");
            }
        }
    }
}
