using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayToSort = new int[] { 5, 1, 4, 2, 8 };
            BubbleSort(arrayToSort, arrayToSort.Length-1);

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.WriteLine(arrayToSort[i]);
            }
        }

        private static void BubbleSort(int[] arrayToSort, int length)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length-i; j++)
                {
                    if (arrayToSort[j]>arrayToSort[j+1])
                    {
                        swapArrayPosition(arrayToSort, j);
                    }
                }
            }
        }

        private static void swapArrayPosition(int[] arrayToSort, int j)
        {
            int temp = arrayToSort[j];
            arrayToSort[j] = arrayToSort[j + 1];
            arrayToSort[j + 1] = temp;
        }
    }
}
