using System;
using System.Collections.Generic;

namespace PrintAllAnagrams
{
    class Program
    {
        public static void Main(String[] args)
        {
            String[] arr = { "cat", "dog", "tac",
                         "ogd", "act" };
            printAnagrams(arr);
        }

        private static void printAnagrams(string[] arr)
        {
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
            for (int i = 0; i < arr.Length; i++)
            {
                string word = arr[i];
                char[] charArray = arr[i].ToCharArray();

                Array.Sort(charArray);

                string newWord = new string(charArray);

                if (map.ContainsKey(newWord))
                {
                    map[newWord].Add(word);
                }

                else
                {
                    map.Add(newWord, new List<string>() { word });
                }
            }
           
            foreach (var item in map)
            {
                if (item.Value.Count>1)
                {
                    List<string> anagrams = new List<string>();
                    foreach (var anagram in item.Value)
                    {
                        anagrams.Add(anagram);
                    }
                    Console.WriteLine($"[{string.Join(',',anagrams.ToArray())}]");
                }
            }
        }
    }
}
