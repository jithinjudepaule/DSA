using System;
using System.Collections.Generic;

namespace FindElementAppearingOnce
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 7, 3, 5, 4, 5, 3, 4 };
            findElementAppearingOnce(array);
        }

        static void findElementAppearingOnce(int[] array)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            int result;
            for (int i = 0; i < array.Length; i++)
            {
                if (keyValuePairs.ContainsKey(array[i]))
                {
                    keyValuePairs.TryGetValue(array[i], out result);
                    result++;
                    keyValuePairs[array[i]] = result;
                }

                else
                {
                    keyValuePairs.Add(array[i], 1);
                }
            }

            foreach (var item in keyValuePairs)
            {
                if (item.Value==1)
                {
                    Console.WriteLine(item.Key);
                }
            }

            
        }

    }
}
