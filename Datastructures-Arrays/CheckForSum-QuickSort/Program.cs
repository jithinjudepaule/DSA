using System;

namespace CheckForSum_QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 13, 17, 9, 12, 2, 7 };
            quickSort(array,0,array.Length-1);
            bool result = checkIfSumExists(array, 14);
            if (result)
            {
                Console.WriteLine("Sum found");
            }
            else
            {
                Console.WriteLine("Sum Not found");
            }
           
        }

        private static bool checkIfSumExists(int[] array, int sum)
        {
            int low = 0;
            int high = array.Length - 1;
            while (low<high)
            {
                if (array[low] + array[high] == sum)
                {
                    return true;
                }

                if (array[low] + array[high] < sum)
                {
                    low++;
                }
                else
                {
                    high--;
                }
            }
            return false;
        }

        static void quickSort(int[] array,int low,int high)
        {
            if (low<high)
            {
                int partitionIndex = partition(array, low, high);
                quickSort(array, low, partitionIndex - 1);
                quickSort(array, partitionIndex + 1, high);
            }
        }

        private static int partition(int[] array, int low, int high)
        {
            int i = low-1;
            int pivot = array[high];
            for (int j = low; j < high; j++)
            {
                if (array[j]<=pivot)
                {
                    i++;
                    swapArrays(array, j, i);
                }
              
            }
            swapArrays(array, i + 1, high);
            return i + 1;
        }

        private static void swapArrays(int[] array, int j, int i)
        {
            int temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }
    }
}
