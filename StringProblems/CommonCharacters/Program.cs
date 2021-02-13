using System;
using System.Collections.Generic;

namespace CommonCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "geeks";
            string string2 = "for geeks";

            FindRepeatingCharacters(string1, string2);
        }

        private static void FindRepeatingCharacters(string string1, string string2)
        {
            HashSet<char> hashSet = new HashSet<char>();
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            for (int i = 0; i < string1.Length; i++)
            {
                hashSet.Add(string1[i]);
            }

            for (int i = 0; i < string2.Length; i++)
            {
                if (hashSet.Contains(string2[i]))
                {
                    if (keyValuePairs.ContainsKey(string2[i]))
                    {
                        keyValuePairs[string2[i]]++;
                    }

                    else
                    {
                        keyValuePairs.Add(string2[i], 1);
                    }
                    
                }
            }

            foreach (var item in keyValuePairs)
            {
                if (item.Value>0)
                {
                    Console.WriteLine($"{item.Key} appears {item.Value} time(s)");
                }
            }
        }
    }
}
