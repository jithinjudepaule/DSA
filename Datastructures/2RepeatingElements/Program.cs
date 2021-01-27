using System;
using System.Collections.Generic;

namespace _2RepeatingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 2, 4, 5, 2, 3, 1 };
            FindRepeatingElements(array);
        }
        static void FindRepeatingElements(int[] array)
        { 
            Dictionary<int, int> elementsCount = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (elementsCount.ContainsKey(array[i]))
                {
                    elementsCount[array[i]]++;
                }
                else
                {
                    elementsCount.Add(array[i], 1);
                }
            }

            foreach (var item in elementsCount)
            {
                if (item.Value>1)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
