using System;
using System.Collections.Generic;

namespace Distinct
{
    class Program
    {
        static void Main(string[] args)
        {
          FindDistinct("Hello World!");
        }

        private static void FindDistinct(string testString)
        {
            char[] strArray = testString.ToCharArray();
            Dictionary<char, int> dictionaryCount = new Dictionary<char, int>();
            for (int i = 0; i < strArray.Length; i++)
            {
                if (dictionaryCount.ContainsKey(strArray[i]))
                {
                    dictionaryCount[strArray[i]]++; 
                }
                else
                {
                    dictionaryCount.Add(strArray[i], 1);
                }
            }
            string distinct = "";
            foreach (var item in dictionaryCount)
            {
                if (item.Value==1)
                {
                    distinct += item.Key;
                }
            }
            Console.WriteLine(distinct);
            
        }
    }

}
