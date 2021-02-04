using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckSubstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Substrings.FindSubstrring();
            string str = "aba";
            int distinctCharacters = 2;
            int substringCount = FindDistinctCount(str, distinctCharacters);
            Console.WriteLine($"Count is {substringCount}");
        }

        private static int FindDistinctCount(string str, int distinctCharacters)
        {
            int count = 0;
            HashSet<char> distinctcollection = new HashSet<char>();
          
            for (int i = 0; i < str.Length; i++)
            {
                string substr = "";
                for (int j = i; j < str.Length; j++)
                {
                    if (substr.Contains(str[j]))
                    {
                        substr += str[j];
                    }
                    

                    else
                    {
                        substr += str[j];
                        distinctcollection.Add(str[j]);
                        if (distinctcollection.Count > distinctCharacters)
                        {
                            count++;
                            Console.WriteLine(substr);
                            break;
                        }
                    }
                }
            }
            return count;
        }
    }
}
