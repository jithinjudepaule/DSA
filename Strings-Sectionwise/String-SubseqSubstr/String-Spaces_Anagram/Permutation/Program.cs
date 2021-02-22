using System;
using System.Collections.Generic;

namespace Permutation
{
    class Program
    {
        static int count=0;
        static HashSet<string> hash = new HashSet<string>();
        static void Main(string[] args)
        {
            FindPermutation("geeks",0,4);
            Console.WriteLine(count);
            Console.WriteLine(hash.Count);
          
        }

        private static void FindPermutation(string str,int low, int high)
        {
            count++;

            if (low == high)
            {
                Console.WriteLine(str);
                hash.Add(str);
               
            }
            else
            {
                for (int i = low; i <= str.Length - 1; i++)
                {
                    str = Swap(str.ToCharArray(), low, i);
                    FindPermutation(str, low + 1, high);
                    str = Swap(str.ToCharArray(), low, i);
                }
            }
         
        }

        private static string Swap(char[] str, int low, int i)
        {
            char temp = str[low];
            str[low] = str[i];
            str[i] = temp;

            return new string(str);
        }
    }
}
