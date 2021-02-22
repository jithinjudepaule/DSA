using System;
using System.Collections.Generic;

namespace AlienDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[] { "baa", "abcd", "abca", "cab", "cad" };
            FindOrder(stringArray);
        }
        static void FindOrder(string[] stringArray)
        {
            
            Dictionary<string, List<char>> keyValuePairs = new Dictionary<string, List<char>>();
            HashSet<char> hash = new HashSet<char>();

            for (int i = 0; i < stringArray.Length; i++)
            {
                List<char> sortedChars = new List<char>();
                for (int j = 0; j < stringArray[i].Length; j++)
                {
                    sortedChars.Add(stringArray[i][j]);
                }

                keyValuePairs.Add(stringArray[i], sortedChars);
            }

            foreach (var sortedList in keyValuePairs.Values)
            {
                for (int i = 0; i < sortedList.Count; i++)
                {
                    hash.Add(sortedList[i]);
                }
            }

            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
        }
    }
}
