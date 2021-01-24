using System;

namespace LeadersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 16, 17, 4, 3, 5, 2 };
            FindLeadersInArray(array);
        }

        private static void FindLeadersInArray(int[] array)
        {
            int lSum = 0;
            int sum = 0;
            int rSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                lSum = lSum + array[i];
                rSum = sum- lSum;
                if (array[i]> rSum)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
