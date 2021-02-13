using System;
using System.Collections.Generic;
using System.Globalization;

namespace CommonCharacterNStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[] { "geeksforgeeks", "gemkstones", "acknowledges", "aguelikes" };
            FindCommonCharacters(stringArray);
        }

        static void FindCommonCharacters(string[] stringArray)
        {
            HashSet<char> hashSet = new HashSet<char>();
            for (int i = 0; i < stringArray[0].Length; i++)
            {
                if (!hashSet.Contains(stringArray[0][i]))
                {
                    hashSet.Add(stringArray[0][i]);
                }
            }

        }
    }
}
