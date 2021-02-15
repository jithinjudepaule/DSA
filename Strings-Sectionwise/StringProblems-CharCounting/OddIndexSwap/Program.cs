using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
   

    static void Main(string[] args)
    {
        string[] stringArray = new string[] {"abcd", "acbd", "adcb", "cdba",
                "bcda", "badc"};

        FindDistinctCharacters(stringArray);
    }

    private static void FindDistinctCharacters(string[] stringArray)
    {
        int count = 0;
        HashSet<string> hashSet = new HashSet<string>();
        for (int i = 0; i < stringArray.Length; i++)
        {
            
            
            string encodedString = EncodedString(stringArray[i]);
            if (!hashSet.Contains(encodedString))
            {
                hashSet.Add(encodedString);
                count++;
            }
        }
        Console.WriteLine($"Total count is {count}");
    }

    private static string EncodedString(string testString)
    {
        int[] hashOdd = new int[26];
        int[] hashEven = new int[26];

        for (int i = 0; i < testString.Length; i++)
        {
            if ((i%2)==0)
            {
                hashEven[testString[i]-'a']++;
            }
            else
            {
                hashOdd[testString[i]-'a']++;
            }
        }

        string encodedString = "";

        for (int i = 0; i < 26; i++)
        {
            encodedString += hashEven[i];
            encodedString += "-";
            encodedString += hashOdd[i];
            encodedString += "-";
        }
        return encodedString;
    }
}
