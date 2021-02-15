using System;

public class Program
{
    static void Main()
    {
        string testString = "This is a test string";
        string pattern = "tist";
        FindSmallestWindow(testString, pattern);
    }

    private static void FindSmallestWindow(string testString, string pattern)
    {
        int[] hashPattern = new int[256];
        int[] hashString = new int[256];
        for (int i = 0; i < pattern.Length; i++)
        {
            hashPattern[pattern[i]]++;
        }

        int start = 0; 
        int startIndex = -1; 
        int minLength = int.MaxValue;
        int lengthWindow = 0;
        int count = 0;

        for (int j = 0; j < testString.Length; j++)
        {
            hashString[testString[j]]++;
            if (hashString[testString[j]]<= hashPattern[testString[j]])
            {
                 count++;
            }

            if (count == pattern.Length)
            {
                while ((hashString[testString[start]]>hashPattern[testString[start]])|| 
                    hashPattern[testString[start]]==0)
                {
                    if (hashString[testString[start]] > hashPattern[testString[start]])
                    {
                        hashString[testString[start]]--;
                    }
                    start++;
                }
                lengthWindow = j - start + 1;
                if (minLength>lengthWindow)
                {
                    minLength = lengthWindow;
                    startIndex = start;
                }
            }
        }

        Console.WriteLine(testString.Substring(startIndex,minLength));

    }
}