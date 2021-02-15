using System;
using System.Collections.Generic;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Check for Duplicates";
            CheckForDuplicate(str);
        }

        static void CheckForDuplicate(string str)
        {
            char[] charArray = str.ToCharArray();
            HashSet<char> hashset = new HashSet<char>();
            string uniqueString = "";
            for (int i = 0; i < charArray.Length; i++)
            {
                if (hashset.Contains(charArray[i]) && charArray[i]!=' ')
                {
                    continue;
                }
                else
                {
                    hashset.Add(charArray[i]);
                    uniqueString += charArray[i];
                }
            }
            Console.WriteLine(uniqueString);
            
        }
    }
}
