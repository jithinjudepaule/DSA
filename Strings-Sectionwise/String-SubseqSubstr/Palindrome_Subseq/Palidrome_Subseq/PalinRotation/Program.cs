using System;
using System.Collections.Generic;

namespace PalinRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string strPalin = "aa";
            if (CheckIfRotation(strPalin))
            {
                Console.WriteLine("Is Rotation" );
            }
            else
            {
                Console.WriteLine("Not a rotation");
            }
        }

        static bool CheckIfRotation(string strPalin)
        {
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            for (int i = 0; i < strPalin.Length; i++)
            {
                if (keyValuePairs.ContainsKey(strPalin[i]))
                {
                    keyValuePairs[strPalin[i]]++;
                }
                else
                {
                    keyValuePairs.Add(strPalin[i], 1)
;                }
            }
            int countOf1 = 0;
            foreach (var item in keyValuePairs)
            {
                if (item.Value%2==0)
                {
                    continue;
                }
                else if(item.Value % 2 == 1 && item.Value==1)
                {
                    countOf1++;
                    continue;
                }
               
                else
                {
                    return false;
                    
                }
            }
            if (countOf1 > 1)
            {
                Console.WriteLine(countOf1-1);
                return false;
            }
            else
            {
                Console.WriteLine(countOf1);
            }
            return true;
        }
    }
}
