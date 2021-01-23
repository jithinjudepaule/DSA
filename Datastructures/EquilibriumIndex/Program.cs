using System;
using System.Linq;

namespace EquilibriumIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 12, -9, 3, 1, 4, -3, 5 };
            int equilibriumIndex = FindEquilibriumIndex(array);
            if (equilibriumIndex!=-1)
            {
                Console.WriteLine($"Equilibrium Index={equilibriumIndex}");
            }
            else
            {
                Console.WriteLine("Equilibrium Index not found");
            }
        }

        static int FindEquilibriumIndex(int[] array)
        {
            int sum = array.Aggregate(func: Add);
            int lSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum -= array[i];
                if (sum==lSum)
                {
                    return i;
                }
                lSum = lSum + array[i];
            }
            return -1;
            
        }

       static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
