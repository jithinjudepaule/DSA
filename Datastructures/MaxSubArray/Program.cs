using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3,-11, 14, 5, -4, 6 };
            int[] array2 = new int[] { 1,5};

            int maxSum=findMaxSubArray(array, array2);
            Console.WriteLine(maxSum);
        }

        private static int findMaxSubArray(int[] array, int[] array2)
        {
            int sum = 0;
            int contSum = 0;
            int MaxSum = 0;
            var array2List = array2.ToList();
            for (int i = 0; i < array.Length; i++)
            {
                if (array2List.Contains(array[i]))
                {
                    contSum = 0;
                    continue;
                    
                }
                contSum = Math.Max(array[i],contSum + array[i]);
                MaxSum = Math.Max(contSum, MaxSum);

            }
            return MaxSum;
        }
    }
}
