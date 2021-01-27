using System;
using System.Collections.Generic;

namespace Find_IfSumIsInSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 2, -2, -20, 11 };
            FindSubarray(array, -19);
        }

        private static void FindSubarray(int[] array, int sum)
        {
            int currentSum = 0;
            int start = 0;
            int end = -1;
            Dictionary<int, int> hashMap = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                currentSum = currentSum + array[i];
                if (currentSum-sum==0)
                {
                    start = 0;
                    end = i;
                    break;
                }

                if (hashMap.ContainsKey(currentSum - sum))
                {
                    start = hashMap[currentSum - sum] + 1;
                    end = i;
                    break;
                }
                hashMap[currentSum] = i;
            }
            if (end==-1)
            {
                Console.WriteLine("No Sub Array found");
            }
            else
            {
                Console.WriteLine($"The sub array was found at {start} to {end}");
            }
        }
    }
}
