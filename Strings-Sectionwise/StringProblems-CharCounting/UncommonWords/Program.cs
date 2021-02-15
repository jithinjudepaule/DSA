using System;
using System.Collections.Generic;

namespace UncommonWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "geeks for geeks";
            string string2 = "geeksquiz";
            FindUncommon(string1, string2);
        }

        private static void FindUncommon(string string1, string string2)
        {
            HashSet<char> hashSet = new HashSet<char>();

            for (int i = 0; i < string1.Length; i++)
            {
                if (!hashSet.Contains(string1[i]))
                {
                    hashSet.Add(string1[i]);
                }
            }
        }
    }
}
