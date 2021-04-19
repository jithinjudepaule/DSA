using Microsoft.VisualBasic;
using System;

namespace TripletsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, -1, 5, 0, 8, -10 };
            FindTriplets(array);
        }
        static void FindTriplets(int[] array)
        {
            QuickSort(array,0,array.Length-1);
            Console.WriteLine($"The triplets are {array[array.Length-3]} {array[array.Length - 2]} {array[array.Length - 1]}");
        }

        private static void QuickSort(int[] array, int low, int high)
        {
            if (low<high)
            {
                int partitionIndex = Partition(array, low, high);
                 QuickSort(array, low, partitionIndex - 1);
                QuickSort(array, partitionIndex + 1, high);
            }
        }

        private static int Partition(int[] array, int low, int high)
        {
            int i = low - 1;
            int pivot = array[high];
            for (int j = low; j < array.Length; j++)
            {
                if (array[j]<pivot)
                {
                    i++;
                    swaparrays(array, i, j);
                }
            }
            swaparrays(array, i + 1, high);
            return i + 1;
        }

        private static void swaparrays(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
