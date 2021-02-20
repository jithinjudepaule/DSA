using System;
using System.Collections.Generic;

namespace Anagram_RemoveChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "bcadeh";
            string str2 = "hea";

            RemoveChars(str1, str2);
        }

        private static void RemoveChars(string str1, string str2)
        {
            int[] str1Count = new int[26];
            List<char> chars = new List<char>();
            for (int i = 0; i < str1.Length; i++)
            {
                str1Count[str1[i] - 'a']++;
            }

            for (int i = 0; i < str2.Length; i++)
            {
                if (str1Count[str2[i] - 'a']==1)
                {
                    str1Count[str2[i] - 'a'] = -1;
                }
               
            }

            for (int i = 0; i < str1.Length; i++)
            {
                 if (str1Count[str1[i] - 'a'] == 1)
                {
                    chars.Add(str1[i]);
                }
            }

            Console.WriteLine($"Total Chars to remove {chars.Count} and chars are {new string(chars.ToArray())}");
        }
    }
}
