using System;
using System.Collections.Generic;

namespace MajorityElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 3, 4, 2, 4, 4, 2, 4, 4 };

            FindMajorityElement(array);
        }

        private static void FindMajorityElement(int[] array)
        {
            Dictionary<int, int> majorityElements = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (majorityElements.ContainsKey(array[i]))
                {
                    majorityElements[array[i]]++;
                }

                else
                {
                    majorityElements.Add(array[i], 1);
                }
            }

            foreach (var item in majorityElements)
            {
                if (item.Value>(array.Length/2))
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
